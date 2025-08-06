# LogosAuth

- A secure authentication system built using C# and .NET Core, featuring JWT-based login, refresh token flows, and role-based authorization. Implemented low-level security optimizations, efficient memory management, and comprehensive error handling. Designed with layered architecture emphasizing system reliability and performance debugging capabilities.

## Features
- **JWT Authentication**: Secure user authentication using JSON Web Tokens.
- **Refresh Token Flow**: Allows users to obtain new access tokens without re-authenticating.
- **Role-Based Authorization**: Fine-grained access control based on user roles.
- **Layered Architecture**: Organized code structure for maintainability and scalability.
- **Security Optimizations**: Implemented low-level security measures to protect sensitive data.
- **Password Hashing**: Securely hashes user passwords using industry-standard algorithms.
- ** clean Code**: Focused on writing clean, maintainable, and efficient code. Controllers → Services → Repositories → EF Core

## Technologies Used
- **C#**: Primary programming language for backend development.
- **.NET Core 9**: Framework for building the application.
- **Entity Framework Core**: ORM for database interactions.
- **SQL Server**: Database for storing user data and authentication information.
- **JWT**: For secure token-based authentication.
- **Scalar**: API testing with Scalar

## Getting Started

- Clone the repository:
```bash
git clone https://github.com/cliff-gor/LogosAuth.git
```
- update the connection string in `appsettings.json` to point to your SQL Server instance.
- run the migrations to set up the database:
```bash
dotnet ef database update
```

- Update appsettings.json with your JWT
- Run the application:
```bash
dotnet run
```

## Author 

- [Cliff Gor](https://www.linkedin.com/in/cliff-gor/)