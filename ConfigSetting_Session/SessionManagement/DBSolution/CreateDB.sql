CREATE DATABASE onlineshopping;

USE onlineshopping;

-- Create the Product table
CREATE TABLE Product (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(50) ,
    Description VARCHAR(255) ,
    ImageUrl VARCHAR(100) ,
    Quantity INT ,
    UnitPrice DOUBLE  
); 

SELECT * FROM Product;

-- Create the Customers table
CREATE TABLE Customers (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) ,
    ContactNumber INT ,
    Email VARCHAR(255) ,
    Location VARCHAR(255) ,
    Age INT     
);

SELECT * FROM Customers;

-- Create the Orders table
CREATE TABLE Orders (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    OrderDate DATE NOT NULL,
    TotalAmount DECIMAL(10, 2),
    Status VARCHAR(50),
    UserID INT,
    FOREIGN KEY (UserID) REFERENCES Users(Id) ON DELETE CASCADE ON UPDATE CASCADE
);

SELECT * FROM Orders;

-- Create the Flowers table
CREATE TABLE Flowers (
    ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(255),
    SalePrice DECIMAL(10, 2),
    UnitPrice DECIMAL(10, 2),
    Quantity INT
);

SELECT * FROM Flowers;

-- Create the Fruit table
CREATE TABLE Fruits (
    ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    MovieName VARCHAR(255),
    Quantity INT
);

SELECT * FROM Fruits;

-- Create the Users table
CREATE TABLE Users (
    Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100) NOT NULL,
    Location VARCHAR(100),
    Email VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    ContactNumber INT NOT NULL
);

SELECT * FROM Users;

-- Create the Payments table

