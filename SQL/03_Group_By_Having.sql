/*
Round 0 - SQL Practice 03
Question: Find departments with more than one employee.
Also demonstrates WHERE vs HAVING.
SQL Server / SSMS
*/

SET NOCOUNT ON;

DROP TABLE IF EXISTS #Employees;

CREATE TABLE #Employees
(
    EmployeeId INT PRIMARY KEY,
    EmployeeName VARCHAR(50) NOT NULL,
    DepartmentId INT NULL,
    Salary DECIMAL(10, 2) NOT NULL
);

INSERT INTO #Employees (EmployeeId, EmployeeName, DepartmentId, Salary)
VALUES
    (1, 'Alex', 10, 50000),
    (2, 'John', 20, 70000),
    (3, 'Mary', 10, 70000),
    (4, 'Sam', NULL, 40000),
    (5, 'Nina', 10, 45000),
    (6, 'Omar', 20, 48000);

-- WHERE filters rows before grouping.
-- HAVING filters groups after aggregation.
SELECT
    DepartmentId,
    COUNT(*) AS EmployeeCount,
    AVG(Salary) AS AverageSalary
FROM #Employees
WHERE DepartmentId IS NOT NULL
GROUP BY DepartmentId
HAVING COUNT(*) > 1
ORDER BY DepartmentId;
-- Expected:
-- Department 10: 3 employees, average salary 55000.00
-- Department 20: 2 employees, average salary 59000.00

DROP TABLE IF EXISTS #Employees;
