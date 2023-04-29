CREATE OR ALTER PROCEDURE DMV.GetQueryRegisteredDrivers
	@FirstName NVARCHAR(32) NULL,
	@MiddleName NVARCHAR(32) NULL,
	@LastName NVARCHAR(32) NULL,
	@Sex NCHAR(1) NULL
AS

SELECT RD.RegisteredDriverID,
	RD.FirstName,
	RD.MiddleName,
	RD.LastName,
	RD.Sex,
	RD.DateOfBirth
FROM DMV.RegisteredDrivers RD
WHERE RD.FirstName LIKE IIF(@FirstName IS NULL, '%', @FirstName)
	AND RD.MiddleName LIKE IIF(@MiddleName IS NULL, '%', @MiddleName)
	AND RD.LastName LIKE IIF(@LastName IS NULL, '%', @LastName)
	AND RD.Sex LIKE IIF(@Sex IS NULL, '%', @Sex)