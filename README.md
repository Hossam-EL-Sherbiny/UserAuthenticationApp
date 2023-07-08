# AuthenticationUser Application
The AuthenticationUser application is a console-based user authentication system implemented in C#.
It provides basic functionality for user registration, login, and password management.

## Purpose
This application was developed as a practical project to reinforce the concepts of user authentication and unit testing.
The main goal of this project is to provide a simplified implementation of user authentication logic and demonstrate the importance of writing unit tests to ensure the correctness and reliability of the authentication system.

## Features
- User Registration: Allows users to register by providing a unique username and a password.
- User Login: Verifies user credentials and grants access if the provided username and password match the registered user.
- Password Management: Ensures secure storage of passwords through hashing techniques.
- Error Handling: Properly handles various error scenarios, such as invalid inputs or existing usernames during registration.

## Unit Tests
This project includes a comprehensive suite of unit tests written using Xunit to validate the behavior of the authentication methods.
To run the tests, navigate to the AuthenticationUser.
Tests project directory and execute the dotnet test command.
