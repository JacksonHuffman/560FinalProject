CREATE OR ALTER PROCEDURE DMV.UpdateRegisteredDriver
	@RegisteredDriverID INT,
	@FirstName NVARCHAR(32),
	@MiddleName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@DateOfBirth DATE,
	@Sex NCHAR(1)
AS

UPDATE DMV.RegisteredDrivers
SET
	FirstName = @FirstName,
	MiddleName = @MiddleName,
	LastName = @LastName,
	DateOfBirth = @DateOfBirth,
	Sex = @Sex
WHERE RegisteredDriverID = @RegisteredDriverID

	

