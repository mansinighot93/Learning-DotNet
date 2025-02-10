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

CREATE TABLE Accounts (     
    AccountId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    UserId INT NOT NULL,     
    AccountNumber VARCHAR(20) NOT NULL, 
    BankName VARCHAR(255),    
    IFSCCode VARCHAR(20),    
    Balance DECIMAL(18,2),     
    FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE ON UPDATE CASCADE 
);


CREATE TABLE Transactions (     
    Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    ToAccountId INT NOT NULL,
    FromAccountId INT NOT NULL,
    Amount DECIMAL(18,2),    
    TransactionDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    
    -- Foreign key constraint for ToAccountId with CASCADE actions
    FOREIGN KEY (ToAccountId) REFERENCES Accounts(AccountId) ON DELETE CASCADE ON UPDATE CASCADE,
    
    -- Foreign key constraint for FromAccountId with no CASCADE actions
    FOREIGN KEY (FromAccountId) REFERENCES Accounts(AccountId) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE Cards (
    Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    AccountId INT,
    CardType VARCHAR(100) CHECK(CardType IN ('Credit Card', 'Debit Card')) NOT NULL,
    CardNumber VARCHAR(500) NOT NULL,
    FOREIGN KEY (AccountId) REFERENCES Accounts(AccountId) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Payments (
    Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    OrderId INT NOT NULL,
    PaymentDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PaymentAmount DECIMAL(10, 2) NOT NULL,
    PaymentMode VARCHAR(50) NOT NULL,
    PaymentStatus VARCHAR(50) NOT NULL DEFAULT 'Pending',
    FOREIGN KEY (OrderId) REFERENCES Orders(Id) ON UPDATE CASCADE ON DELETE CASCADE
);

SELECT * FROM Payments;

