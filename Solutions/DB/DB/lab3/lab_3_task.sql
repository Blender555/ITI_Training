create database task;

create table Employees(
Email nvarchar,
Lastname nvarchar,
PhoneNumber int
);

exec sp_rename 'Lastname','Last_name','COLUMN';

alter table Employees
add Address nvarchar;

alter table Employees
add PhoneNumber VARCHAR(20);

alter table Employees
add Email VARCHAR(20);

exec sp_rename 'Employees','Staff';

-----------------------------

BACKUP DATABASE SchoolDB 
to disk = 'C:\Backup\SchoolDB.bak';

BACKUP DATABASE SchoolDB 
to disk = 'C:\Backup\DiffBackup\DiffSchoolDB.bak' WITH DIFFERENTIAL;

RESTORE DATABASE SchoolDB from disk = 'C:\Backup\SchoolDB.bak';

-----------------------------

CREATE TABLE Employees (
    EmployeeID int identity(1,1) primary key,
    Name VARCHAR(35),
    Salary INT,
    Department VARCHAR(20)
);

INSERT INTO Employees (Name, Salary, Department)
VALUES ('ahmed', 7000, 'IT');

UPDATE Employees
SET Salary = 5000
WHERE EmployeeID = 1;

DELETE FROM Employees
WHERE EmployeeID = 2;

SELECT *
INTO EmployeesBackup
FROM Employees;

INSERT INTO Employees
SELECT * FROM EmployeesBackup;

-----------------------------

CREATE TABLE Students (
    StudentID int identity(1,1)
);

delete from Employees;

truncate table Employees;

-----------------------------

ALTER TABLE Employees
ADD FOREIGN KEY (DepartmentID)
REFERENCES Departments(DepartmentID);

-----------------------------

restore database Employees
from disk = 'D:\Study\ITI_Training\Labs\Problems\HR_Database.bak';

select * from Employees;

select distinct DepartmentID from Employees;

select * from Employees 
where Age > 30 and Salary < 5000;

select * from Employees
where DepartmentID in (1, 2, 3);

select * from Employees
order by LastName;

select top 5 * from Employees
order by Salary desc;

select FirstName as EmployeeFirstName from Employees;

select * from Employees
where Age BETWEEN 25 AND 35;











