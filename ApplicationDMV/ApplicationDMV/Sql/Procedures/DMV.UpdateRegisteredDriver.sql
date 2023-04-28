CREATE OR ALTER PROCEDURE DMV.UpdateRegisteredDriver
	@RegisteredDriverID INT,
	@FirstName NVARCHAR(32),
	@MiddleName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@DateOfBirth DATE,
	@Sex NCHAR(1)
AS

WITH MergeCte(RegisteredDriverID, FirstName, MiddleName, LastName, DateOfBirth, Sex) AS
	(
		SELECT M.RegisteredDriverID,
			M.FirstName,
			M.MiddleName,
			M.LastName,
			M.DateOfBirth,
			M.Sex
		FROM
			(
				VALUES(@RegisteredDriverID, @FirstName, @MiddleName, @LastName, @DateOfBirth, @Sex)
			) M(RegisteredDriverID, FirstName, MiddleName, LastName, DateOfBirth, Sex)
	) 
MERGE DMV.RegisteredDrivers RD
USING MergeCte S ON S.RegisteredDriverID = RD.RegisteredDriverID
WHEN MATCHED THEN
UPDATE
SET
	FirstName = S.FirstName,
	MiddleName = S.MiddleName,
	LastName = S.LastName,
	DateOfBirth = S.DateOfBirth,
	Sex = S.Sex;
