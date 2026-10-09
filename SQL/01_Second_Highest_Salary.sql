/*
Round 0 - SQL Practice 01
Question: Find the second-highest DISTINCT salary.
SQL Server / SSMS
*/

SET NOCOUNT ON;

DROP TABLE IF EXISTS #Employees;

CREATE TABLE #Employees
(
    EmployeeId INT PRIMARY KEY,
    EmployeeName VARCHAR(50) NOT NULL,
    Salary DECIMAL(10, 2) NOT NULL
);

INSERT INTO #Employees (EmployeeId, EmployeeName, Salary)
VALUES
    (1, 'Alex', 50000),
    (2, 'John', 70000),
    (3, 'Mary', 70000),
    (4, 'Sam', 40000),
    (5, 'Priya', 60000);

-- Method 1: MAX() subquery
SELECT MAX(Salary) AS SecondHighestSalary
FROM #Employees
WHERE Salary < (SELECT MAX(Salary) FROM #Employees);
-- Expected: 60000.00

-- Method 2: DENSE_RANK()
;WITH SalaryRanks AS
(
    SELECT
        Salary,
        DENSE_RANK() OVER (ORDER BY Salary DESC) AS SalaryRank
    FROM #Employees
)
SELECT DISTINCT Salary AS SecondHighestSalary
FROM SalaryRanks
WHERE SalaryRank = 2;
-- Expected: 60000.00

DROP TABLE IF EXISTS #Employees;
