CREATE OR ALTER PROCEDURE DMV.GetRegisteredDriverID
	@FirstName NVARCHAR(32),
	@MiddleName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@DateOfBirth DATE,
	@Sex NCHAR(1)
AS

SELECT RD.RegisteredDriverID
FROM DMV.RegisteredDrivers RD
WHERE RD.FirstName = @FirstName
	AND RD.MiddleName = @MiddleName
	AND RD.LastName = @LastName
	AND RD.DateOfBirth = @DateOfBirth
	AND RD.Sex = @Sex