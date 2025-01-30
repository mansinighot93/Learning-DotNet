-- Insert data into the Product table
INSERT INTO Product(Title,Description , Quantity, UnitPrice, ImageUrl) VALUES
('Gerbera','Wedding Flower', 50, 550,'/Images/Gerbera.jpg'),
('Rose','Valentine Flower', 10, 990,'/Images/Rose.jpg'),
('Lotus','Water Flower', 30, 990,'/Images/Lotus.jpg'),
('Jasmine','Valentine Flower', 20, 990,'/Images/Jasmine.jpg'),
('Lily','Valentine Flower', 45, 990,'/Images/Lily.jpg'),
('Marigold','Valentine Flower', 70, 990,'/Images/Marigold.jpg');


-- Insert data into the Customers table
INSERT INTO Customers(Name,ContactNumber , Email, Location, Age) VALUES
('Kuldip Varma',852963741,'kuldipvarma@gmail.com','Mumbai',41),
('Soham Patil',741258963,'sohampatil@gmail.com','Nashik',25),
('Anjali Mittal',987456321,'anjalimittal@gmail.com','Nagar',30),
('Amit Shaha',1234556,'amitshaha@gmail.com','Pune',22),
('arun_kumar', 741852, 'arun@example.com', '12 MG Road, Delhi',50),
('meera_nair', 963852, 'meera@example.com', '34 Gandhi Street, Mumbai',25),
('vikas_patel', 8996512, 'vikas@example.com', '56 Nehru Avenue, Ahmedabad',32),
('sunita_verma', 123456, 'sunita@example.com', '78 Patel Nagar, Pune',36),
('raj_sharma', 6549852, 'raj@example.com', '90 Ambedkar Road, Bangalore',32),
('anita_singh', 1478523, 'anita@example.com', '123 Ashok Marg, Jaipur',23),
('suresh_reddy', 365298, 'suresh@example.com', '456 Charminar, Hyderabad',40);


-- Insert data into the Flower table
INSERT INTO Flowers (Name, SalePrice, UnitPrice, Quantity) VALUES 
('Rose', 2.50, 1.80, 100),
('Tulip', 1.20, 0.80, 200),
('Orchid', 5.00, 3.80, 50);


-- Insert data into the Fruit table
INSERT INTO Fruits (MovieName, Quantity) VALUES 
('Apple', 150),
('Banana', 200),
('Mango', 75);


-- Insert data into the Users table
INSERT INTO Users (Name, Location, Email, Password, ContactNumber)
VALUES ('John Doe', 'New York', 'john.doe@example.com', 'password123', 123456),
       ('Jane Smith', 'California', 'jane.smith@example.com', 'securepass', 98765),
       ('Alice Johnson', 'Texas', 'alice.johnson@example.com', 'alicepass', 11122);