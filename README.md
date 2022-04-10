# Pierre's Sweet and Savory Treats
##### By Chris DePastene
A treat and flavor tracking application for a bakery
#### Technologies Used
* C#
* .NET 5
* ASP.Net Core
* Entity Framework Core
* MySQL
* LINQ
* HTML
* CSS
* Bootstrap
* Identity

#### Description
A web application for a bakery that allows a user to view, add, edit, and delete treats and flavors. The application utilizes many-to-many relationships to connect these two groups and requires user authentication

#### Setup/Installation Requirements
* Download and install [MySQL Workbench](https://www.mysql.com/products/workbench/) and create a local instance using localhost:3306
* Clone the repository to your desktop
* Open your terminal and run the following command: `dotnet tool install --global dotnet-ef --version 5.0.1`
* Using the terminal, navigate to the root folder of the project directory and run `code .` to launch the project in [VS Code](https://code.visualstudio.com/download)
* Create a `.gitignore` file in the root directory and add the following: `*/bin/` `*/obj/` `appsettings.json`
* From the PierresTreats directory, create an `appsettings.json` file and add the following code: 
```
  {
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[database_name];uid=root;pwd=[password];"
    }
  }
```
* Replace `[database_name]` and `[password]` with your database name and password
* From the PierresTreats directory, run `dotnet restore` to install the necessary dependencies 
* Then import the databse by running `dotnet ef database update`
* Launch the application from your terminal by running the command `dotnet run`, then navigate to http://localhost:5000 in your preferred browser

#### Known Bugs
* None at this time

#### License
[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2022 Christopher DePastene