# UnityServer #

This README would normally document whatever steps are necessary to get your application up and running.

### What is this repository for? ###

* Summary: Connects an ASP.NET Core server (ASPServer) to a Unity game.
* Purpose: Enables real-time communication and data exchange between server and game client.

### How do I get set up? ###

* Summary of set up: This guide outlines the steps to configure and run the ASP.NET Core server to connect with a Unity project.
* Configuration:
	1. Shared Library Path: Update the SharedLibrary.csproj file to reference the correct path to your Unity project's Shared Library. This ensures proper communication between the server and the client.
	2. Database Connection String: Configure the database connection string in both appsettings.json and appsettings.Development.json files. This specifies the location and credentials for the database used by the server.
* Dependencies: Ensure all necessary dependencies are installed.
* Database configuration: Refer to the database connection string setup in appsettings.json and appsettings.Development.json.
* How to run the server:
	1. Run dotnet restore to restore all project dependencies.
	2. Run dotnet run to start the ASP.NET Core server.
* Deployment instructions: (Will be provided later)
