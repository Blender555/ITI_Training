IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'SchoolDB')
begin
CREATE DATABASE SchoolDB;
end

USE SchoolDB;
go
CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Email VARCHAR(50),
    DateOfBirth DATE
);
CREATE TABLE Course (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50),
    Credits INT
);
CREATE TABLE Instructor (
    InstructorID INT PRIMARY KEY,
    InstructorName VARCHAR(50),
    Email VARCHAR(50)
);

IF EXISTS (SELECT * FROM Instructor)
begin
drop table Instructor;	
end

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'SchoolDB')
begin
DROP DATABASE SchoolDB;
end