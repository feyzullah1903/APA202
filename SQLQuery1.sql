-- DATABASE
CREATE DATABASE CompanyMM;
GO

USE CompanyMM;
GO

-- TABLES
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    BirthDate DATE,
    Email NVARCHAR(100) UNIQUE,
    CHECK (BirthDate < GETDATE())
);

CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY IDENTITY(1,1),
    ProjectName NVARCHAR(100),
    StartDate DATE,
    EndDate DATE,
    CHECK (EndDate >= StartDate)
);

CREATE TABLE EmployeeProjects (
    EmployeeID INT,
    ProjectID INT,
    AssignedDate DATE DEFAULT GETDATE(),
    PRIMARY KEY (EmployeeID, ProjectID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
);

-- DATA INSERT
INSERT INTO Employees (FirstName, LastName, BirthDate, Email) VALUES
('Ali','Aliyev','1995-05-10','ali@mail.com'),
('Veli','Memmedov','1993-03-15','veli@mail.com'),
('Aysel','Hesenova','1998-07-22','aysel@mail.com'),
('Murad','Quliyev','1990-11-01','murad@mail.com'),
('Nigar','Ismayilova','1996-09-09','nigar@mail.com');

INSERT INTO Projects (ProjectName, StartDate, EndDate) VALUES
('Website','2024-01-01','2024-06-01'),
('MobileApp','2024-02-01','2024-07-01'),
('CRM System','2024-03-01','2024-08-01');

INSERT INTO EmployeeProjects (EmployeeID, ProjectID) VALUES
(1,1),(1,2),
(2,1),(2,2),(2,3),
(3,2),
(4,1),(4,3),
(5,3);

-- A. SELECT / JOIN / GROUP BY

-- 1
SELECT * FROM Employees;

-- 2
SELECT * FROM Projects;

-- 3
SELECT e.FirstName, e.LastName, p.ProjectName
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;

-- 4
SELECT p.ProjectName, COUNT(ep.EmployeeID) AS EmployeeCount
FROM Projects p
LEFT JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
GROUP BY p.ProjectName;

-- 5
SELECT e.EmployeeID, e.FirstName, e.LastName, COUNT(ep.ProjectID) AS ProjectCount
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(ep.ProjectID) > 2;

-- B. VIEW
CREATE VIEW EmployeeProjectView AS
SELECT 
    e.EmployeeID,
    e.FirstName + ' ' + e.LastName AS FullName,
    p.ProjectID,
    p.ProjectName,
    ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;

-- 7
SELECT * FROM EmployeeProjectView WHERE EmployeeID = 1;

-- C. PROCEDURE
CREATE PROCEDURE sp_AssignEmployeeToProject
    @empId INT,
    @projId INT
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM EmployeeProjects 
        WHERE EmployeeID = @empId AND ProjectID = @projId
    )
    BEGIN
        INSERT INTO EmployeeProjects (EmployeeID, ProjectID)
        VALUES (@empId, @projId);
    END
END;
GO

-- FUNCTION
CREATE FUNCTION fn_GetProjectCount (@empId INT)
RETURNS INT
AS
BEGIN
    DECLARE @count INT;

    SELECT @count = COUNT(*)
    FROM EmployeeProjects
    WHERE EmployeeID = @empId;

    RETURN @count;
END;
GO

-- FUNCTION CALL
SELECT dbo.fn_GetProjectCount(2) AS ProjectCount;

-- E. TEST

EXEC sp_AssignEmployeeToProject 3,1;

SELECT * FROM EmployeeProjects WHERE EmployeeID = 3;

-- DELETE
DELETE FROM EmployeeProjects WHERE EmployeeID = 5;