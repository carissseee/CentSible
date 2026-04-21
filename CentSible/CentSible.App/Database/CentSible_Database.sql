CREATE DATABASE IF NOT EXISTS centsible;
USE centsible;

CREATE TABLE Account (
    accountID INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(50) NOT NULL,
    createdAt DATE,
    currentStreak INT DEFAULT 0,
    highestStreak INT DEFAULT 0,
    lastLogin DATE
);

CREATE TABLE Budget (
    budgetID INT PRIMARY KEY AUTO_INCREMENT,
    accountID INT NOT NULL,
    monthlyLimit DECIMAL(10,2),
    month VARCHAR(20),
    year INT,
    FOREIGN KEY (accountID) REFERENCES Account(accountID)
);

CREATE TABLE Goal (
    goalID INT PRIMARY KEY AUTO_INCREMENT,
    accountID INT NOT NULL,
    goalType ENUM('Spending', 'Saving'),
    targetAmount DECIMAL(10,2),
    currentAmount DECIMAL(10,2) DEFAULT 0,
    targetDate DATE,
    FOREIGN KEY (accountID) REFERENCES Account(accountID)
);

CREATE TABLE Transaction (
    transactionID INT PRIMARY KEY AUTO_INCREMENT,
    accountID INT NOT NULL,
    description VARCHAR(50),
    transactionType ENUM('Income', 'Expense'),
    category ENUM('Budget', 'Food', 'Transportation', 'Utilities', 'Miscellaneous', 'Health', 'Leisure'),
    amount DECIMAL(10,2),
    date DATE,
    FOREIGN KEY (accountID) REFERENCES Account(accountID)
);

CREATE TABLE Monthly_Summary (
    summaryID INT PRIMARY KEY AUTO_INCREMENT,
    accountID INT NOT NULL,
    year INT,
    month VARCHAR(20),
    totalIncome DECIMAL(10,2),
    totalExpense DECIMAL(10,2),
    totalSaving DECIMAL(10,2),
    FOREIGN KEY (accountID) REFERENCES Account(accountID)
);