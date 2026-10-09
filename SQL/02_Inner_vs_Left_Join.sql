/*
Round 0 - SQL Practice 02
Question: Demonstrate INNER JOIN vs LEFT JOIN.
SQL Server / SSMS
*/

SET NOCOUNT ON;

DROP TABLE IF EXISTS #Employees;
DROP TABLE IF EXISTS #Departments;

CREATE TABLE #Departments
(
    DepartmentId INT PRIMARY KEY,
    DepartmentName VARCHAR(50) NOT NULL
);

CREATE TABLE #Employees
(
    EmployeeId INT PRIMARY KEY,
    EmployeeName VARCHAR(50) NOT NULL,
    DepartmentId INT NULL
);

INSERT INTO #Departments (DepartmentId, DepartmentName)
VALUES
    (10, 'IT'),
    (20, 'HR'),
    (30, 'Finance');

INSERT INTO #Employees (EmployeeId, EmployeeName, DepartmentId)
VALUES
    (1, 'Alex', 10),
    (2, 'John', 20),
    (3, 'Mary', 10),
    (4, 'Sam', NULL),
    (5, 'Nina', 99); -- DepartmentId 99 has no matching department

-- INNER JOIN: only employees with a matching department.
SELECT
    e.EmployeeId,
    e.EmployeeName,
    d.DepartmentName
FROM #Employees AS e
INNER JOIN #Departments AS d
    ON e.DepartmentId = d.DepartmentId
ORDER BY e.EmployeeId;
-- Expected: Alex (IT), John (HR), Mary (IT).
-- Sam and Nina are excluded because they have no matching department.

-- LEFT JOIN: every employee is returned.
SELECT
    e.EmployeeId,
    e.EmployeeName,
    d.DepartmentName
FROM #Employees AS e
LEFT JOIN #Departments AS d
    ON e.DepartmentId = d.DepartmentId
ORDER BY e.EmployeeId;
-- Expected: all five employees. Sam and Nina have NULL DepartmentName.

DROP TABLE IF EXISTS #Employees;
DROP TABLE IF EXISTS #Departments;
