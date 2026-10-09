/*
Round 0 - SQL Practice 05
Question: Demonstrate DELETE, TRUNCATE, and DROP.
Important: Each command uses a separate temporary table so the
examples are independent and can all be run in one script.
SQL Server / SSMS
*/

SET NOCOUNT ON;

------------------------------------------------------------
-- A) DELETE: remove selected rows; table structure remains.
------------------------------------------------------------
DROP TABLE IF EXISTS #DeleteDemo;

CREATE TABLE #DeleteDemo
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ItemName VARCHAR(50) NOT NULL
);

INSERT INTO #DeleteDemo (ItemName)
VALUES ('Pen'), ('Pencil'), ('Notebook');

-- Delete one row using WHERE.
DELETE FROM #DeleteDemo
WHERE ItemName = 'Pencil';

SELECT * FROM #DeleteDemo ORDER BY Id;
-- Expected: Pen and Notebook remain.

-- DELETE can also remove all rows while keeping the table.
DELETE FROM #DeleteDemo;

SELECT COUNT(*) AS RowsRemainingAfterDelete
FROM #DeleteDemo;
-- Expected: 0. The table still exists.

DROP TABLE IF EXISTS #DeleteDemo;

------------------------------------------------------------
-- B) TRUNCATE: remove all rows; table structure remains.
------------------------------------------------------------
DROP TABLE IF EXISTS #TruncateDemo;

CREATE TABLE #TruncateDemo
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ItemName VARCHAR(50) NOT NULL
);

INSERT INTO #TruncateDemo (ItemName)
VALUES ('Pen'), ('Pencil'), ('Notebook');

TRUNCATE TABLE #TruncateDemo;

SELECT COUNT(*) AS RowsRemainingAfterTruncate
FROM #TruncateDemo;
-- Expected: 0. The table still exists.

-- Demonstrate that TRUNCATE resets the IDENTITY counter.
INSERT INTO #TruncateDemo (ItemName)
VALUES ('Eraser');

SELECT * FROM #TruncateDemo;
-- Expected: Id = 1, ItemName = Eraser.

DROP TABLE IF EXISTS #TruncateDemo;

------------------------------------------------------------
-- C) DROP: remove the table itself, including its structure.
------------------------------------------------------------
DROP TABLE IF EXISTS #DropDemo;

CREATE TABLE #DropDemo
(
    Id INT PRIMARY KEY,
    ItemName VARCHAR(50) NOT NULL
);

INSERT INTO #DropDemo (Id, ItemName)
VALUES (1, 'Pen'), (2, 'Notebook');

SELECT * FROM #DropDemo;
-- Expected before DROP: two rows.

DROP TABLE #DropDemo;

-- The table no longer exists after DROP.
-- Do not SELECT from #DropDemo here; that would cause an error.

PRINT 'DELETE, TRUNCATE, and DROP examples completed.';
