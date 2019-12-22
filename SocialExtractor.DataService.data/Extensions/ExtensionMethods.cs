﻿using SocialExtractor.DataService.data.Models.User;
using System.Collections.Generic;
using System.Linq;

namespace SocialExtractor.DataService.data.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<User> WithoutPasswords(this IEnumerable<User> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        public static User WithoutPassword(this User user)
        {
            user.Password = null;
            return user;
        }
    }
}
