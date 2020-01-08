# Social Extractor Dataservice

An API for storing and managing data obtained from posts from various social media websites.

## Getting Started

### Requirements

- .NET Core 3.0
- MongoDB 4.2.2
- MongoDB Driver 2.9.3

### Build

1. Clone the repository `git clone https://github.com/jeffvhuang/social-extractor-api`
2. Build and run the solution via dotnet. The quickest way is to open in Visual Studio and run on IIS Express. Make sure SocialExtractor.DataService.presentation is set as the startup project.
3. Almost all endpoints require authentication. On initial build, an administrator user will be created (username: "admin") as seen in UserManager.cs in SocialExtractor.DataService.domain project. The initial password is set to "adminpw!". Make a POST request to /users/authenticate with these login details and you will receive a token in the response. Use this to set authorisation bearer token headers on restricted endpoints.

## Production

This is not currently deployed anywhere.

## Authors

Jeffrey Huang (jeffvh@outlook.com)
