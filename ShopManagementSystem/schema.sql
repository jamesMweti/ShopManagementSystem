-- Shop Management System - MySQL 8+ schema.
-- The application runs this script automatically at start-up, so it is safe to run repeatedly.
CREATE DATABASE IF NOT EXISTS shop_management_db CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE shop_management_db;

CREATE TABLE IF NOT EXISTS Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Email VARCHAR(150) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Role VARCHAR(20) NOT NULL DEFAULT 'Cashier',
    Status VARCHAR(10) NOT NULL DEFAULT 'Active',
    CreatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Categories (
    CategoryID INT AUTO_INCREMENT PRIMARY KEY,
    CategoryName VARCHAR(100) NOT NULL UNIQUE,
    Description VARCHAR(255) NULL
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Suppliers (
    SupplierID INT AUTO_INCREMENT PRIMARY KEY,
    SupplierName VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(30) NULL,
    Email VARCHAR(150) NULL
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Products (
    ProductID INT AUTO_INCREMENT PRIMARY KEY,
    ProductName VARCHAR(150) NOT NULL,
    CategoryID INT NULL,
    SupplierID INT NULL,
    UnitPrice DECIMAL(12,2) NOT NULL,
    QuantityInStock INT NOT NULL DEFAULT 0,
    ReorderLevel INT NOT NULL DEFAULT 10,
    CONSTRAINT fk_products_category FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID) ON DELETE SET NULL,
    CONSTRAINT fk_products_supplier FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID) ON DELETE SET NULL
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Customers (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(30) NULL,
    Email VARCHAR(150) NULL
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Sales (
    SaleID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NULL,
    UserID INT NOT NULL,
    SaleDate DATETIME NOT NULL,
    Subtotal DECIMAL(12,2) NOT NULL,
    DiscountPercent DECIMAL(5,2) NOT NULL DEFAULT 0,
    Total DECIMAL(12,2) NOT NULL,
    INDEX idx_sales_date (SaleDate),
    CONSTRAINT fk_sales_customer FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE SET NULL,
    CONSTRAINT fk_sales_user FOREIGN KEY (UserID) REFERENCES Users(UserID)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS SaleItems (
    SaleItemID INT AUTO_INCREMENT PRIMARY KEY,
    SaleID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(12,2) NOT NULL,
    LineTotal DECIMAL(12,2) NOT NULL,
    CONSTRAINT fk_items_sale FOREIGN KEY (SaleID) REFERENCES Sales(SaleID) ON DELETE CASCADE,
    CONSTRAINT fk_items_product FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS StockMovements (
    MovementID INT AUTO_INCREMENT PRIMARY KEY,
    ProductID INT NOT NULL,
    UserID INT NULL,
    MovementDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    QuantityChange INT NOT NULL,
    Reason VARCHAR(150) NOT NULL,
    CONSTRAINT fk_move_product FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE,
    CONSTRAINT fk_move_user FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE SET NULL
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Settings (
    SettingKey VARCHAR(50) PRIMARY KEY,
    SettingValue VARCHAR(255) NOT NULL
) ENGINE=InnoDB;

INSERT IGNORE INTO Settings (SettingKey, SettingValue) VALUES ('ShopName', 'My Shop');
