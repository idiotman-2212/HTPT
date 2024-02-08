CREATE DATABASE HTPT; -- Tạo CSDL mới
USE HTPT; -- Sử dụng CSDL mới

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Salary DECIMAL(10, 2),
    HireDate DATE
);
