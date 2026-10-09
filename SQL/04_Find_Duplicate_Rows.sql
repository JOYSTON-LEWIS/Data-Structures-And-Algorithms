/*
Round 0 - SQL Practice 04
Question: Find duplicate email addresses and return the rows
that have those duplicate email addresses.
SQL Server / SSMS
*/

SET NOCOUNT ON;

DROP TABLE IF EXISTS #Users;

CREATE TABLE #Users
(
    UserId INT PRIMARY KEY,
    FullName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL
);

INSERT INTO #Users (UserId, FullName, Email)
VALUES
    (1, 'Alex', 'alex@example.com'),
    (2, 'John', 'john@example.com'),
    (3, 'Alex Smith', 'alex@example.com'),
    (4, 'Mary', 'mary@example.com'),
    (5, 'John Smith', 'john@example.com'),
    (6, 'Priya', 'priya@example.com');

-- Step 1: Identify duplicate email addresses.
SELECT
    Email,
    COUNT(*) AS DuplicateCount
FROM #Users
GROUP BY Email
HAVING COUNT(*) > 1
ORDER BY Email;
-- Expected:
-- alex@example.com: 2
-- john@example.com: 2

-- Step 2: Return all user rows whose email is duplicated.
;WITH DuplicateEmails AS
(
    SELECT Email
    FROM #Users
    GROUP BY Email
    HAVING COUNT(*) > 1
)
SELECT
    u.UserId,
    u.FullName,
    u.Email
FROM #Users AS u
INNER JOIN DuplicateEmails AS d
    ON d.Email = u.Email
ORDER BY u.Email, u.UserId;
-- Expected: UserIds 1, 3, 2, and 5 (ordering follows Email then UserId).

DROP TABLE IF EXISTS #Users;
