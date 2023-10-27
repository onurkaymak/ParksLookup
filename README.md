<br>
<p align="center">
  <u><big>|| <b>Parks Look Up API</b> ||</big></u>
</p>
<p align="center">
  
   <br>
    <a href="https://www.nps.gov/index.htm" style="display:flex;justify-content:center;">
        <img src="https://www.nps.gov/vafo/learn/kidsyouth/images/NPS-Arrowhead_v3.png" style="width:250px;height:250px;">
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/onurkaymak">
            <strong>By Onur Kaymak</strong>
        </a>
    </p>
    <!-- Project Shields -->
    <p align="center">
        <a href="https://github.com/onurkaymak/ParksLookupAPI/graphs/contributors">
            <img src="https://img.shields.io/github/contributors/onurkaymak/ParksLookupAPI.svg?style=plastic">
        </a>
        &nbsp;
        <a href="https://github.com/onurkaymak/ParksLookupAPI/stargazers">
            <img src="https://img.shields.io/github/stars/onurkaymak/ParksLookupAPI.svg?color=yellow&style=plastic">
        </a>
        &nbsp;
        <a href="https://github.com/onurkaymak/ParksLookupAPI/issues">
            <img src="https://img.shields.io/github/issues/onurkaymak/ParksLookupAPI?style=plastic">
        </a>
        &nbsp;
        <a href="https://github.com/jfpalchak/MessageBoardAPI/blob/main/LICENSE.txt">
            <img src="https://img.shields.io/github/license/jfpalchak/MessageBoardAPI?color=orange&style=plastic">
        </a>
    </p>    
</p>

<p align="center">
  <small>Initiated October 27th, 2023.</small>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/onurkaymak/ParksLookupAPI.git"><big>Project Docs</big></a> ·
    <a href="https://github.com/onurkaymak/ParksLookupAPI/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/onurkaymak/ParksLookupAPI/issues"><big>Request Feature</big></a>
</p>

------------------------------
<u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#🤝-contributors">Contributors</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
    * <a href="#🌟-acknowledgements">Acknowledgements</a>
------------------------------

## 🌐 About the Project

### 📖 Description
A national park API that functions as a back-end utilizing RESTful operations and JSON Web Tokens (JWT) for authentication to keep the API Read-Only except for authenticated users.

### 🦠 Known Bugs

* If any bugs are discovered, please contact the author(s).

### 🛠 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core)
* [MySQL 8.0.34](https://dev.mysql.com/)
* [Entity Framework Core 6.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Entity Framework Core CLI Tools 6.0.0](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)
* [Postman](https://www.postman.com/)

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install dotnet-ef
For Entity Framework Core, we'll use a tool called dotnet-ef to reference the project's migrations and update our database accordingly. To install this tool globally, run the following command in your terminal:

```
$ dotnet tool install --global dotnet-ef --version 6.0.0
```

#### Install MySQL Workbench
This project assumes you have MySQL Server and MySQL Workbench installed on your system. If you do not have these tools installed, follow along with the installation steps for the the necessary tools introduced in the series of lessons found here on [LearnHowToProgram](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

[Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need a code editor or text editor. A popular open-source choice for a code editor is VisualStudio Code.

  1) Code Editor Download:
     * [VisualStudio Code](https://code.visualstudio.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [ParksLookup API repository here](https://github.com/onurkaymak/ParksLookupAPI).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/onurkaymak/ParksLookupAPI.git`
  5) Run the command `cd ParksLookupAPI.Solution/ParksLookupAPI` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `code .` to open the project in VisualStudio Code for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [ParksLookup API repository here](hhttps://github.com/onurkaymak/ParksLookupAPI).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and extract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the ParksLookupAPI directory named `appsettings.json`
  2) Add in the following code snippet to the new `appsettings.json` file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    },
    "JWT": {
        "ValidAudience": "example-audience",
        "ValidIssuer": "example-issuer",
        "Secret": "[YOUR-SECRET-HERE]"
  }
}
  ```
  3) Change the server, port, and user id as necessary. Replace `[YOUR-USERNAME-HERE]`, `[YOUR-PASSWORD-HERE]` and `[DATABASE-NAME-HERE]` with your personal MySQL username, password (set at installation of MySQL) and your choice of database name. 
  4) To properly implement JSON Web Tokens for API authorization, replace `[YOUR-SECRET-HERE]` with your own personalized string.
     1) NOTE: The `Secret` is a special string that will be used to encode our JWTs, to make them unique to our application. Depending on what type of algorithm being used, the Secret string will need to be a certain length. **In this case, it needs to be at least 16 characters long**. 
   
  #### Database
  1) Navigate to ParksLookupAPI.Solution/ParksLookupAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/ParksLookupAPI.Solution/ParksLookupAPI`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. 
  4) After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to ParksLookupAPI.Solution/ParksLookupAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/ParksLookupAPI.Solution/ParksLookupAPI`).
  2) Run the command `dotnet run` to have access to the API.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman. You will not be able to utilize authentication in a browser.

### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.

#### Registration
Again, we'll be using Postman for this example. Let's setup a `POST` request to the `accounts/register` endpoint. Select the 'Body' tab, choose the 'raw' radio button, and select 'JSON' from the dropdown selection.

In the Body of the Post request, use the following format:
```
{
    "email": "email@test.com",
    "userName": "testUser",
    "password": "@Password123"
}
```

#### Example Query
```
https://localhost:5000/api/accounts/register
```

