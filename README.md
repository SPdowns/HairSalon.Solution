# Hair Salon

#### Latest version date 2020/07/24

#### By Sean Downs

## Description
This application will track the clients that use specific stylists from Hair Salon Inc

## Specifications

1. **Behavior:** The user will be able to add a stylist
    * **Input Example:** Click to add Stylist
    * **Output Example:** Ed The Hair Stylist

2. **Behavior:** The user will be able to add clients to a stylists client page
    * **Input Example:** Click on Ed The Hair Stylist
    * **Output Example:** Peter the Hair Client

3. **Behavior:** The user will be able to delete clients from thier list.
    * **Input Example:** Delete Client
    * **Output Example:** Peter the Hair Client Deleted

4. **Behavior:** The user will be able to delete Stylist
    * **Input Example:** Delete Stylist
    * **Output Example:** Ed The Hair Stylist Deleted

## Setup and Installation

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)
3. MySQLWorkbench

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Database Import:
1. After configuring a Local SQL instance, open and start the server
2. Create a new SQL tab for executing Queries and enter the following

```
DROP DATABASE IF EXISTS `Sean_Downs`;
CREATE DATABASE `Sean_Downs`;

USE `Sean_Downs`;

CREATE TABLE `Clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `ClientName` varchar(255) DEFAULT NULL,
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ItemId`)
  CONSTRAINT `FK_Items_Categories_CategoryId` FOREIGN KEY (`CategoryId`) REFERENCES `Categories` (`CategoryId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Categories` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CategoryId`)
)  ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

Editing the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.

## Bugs

## Tech used

* C#
* ASP.NET Core MVC
* CSHTML
* CSS
* Entity


### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Sean Downs
