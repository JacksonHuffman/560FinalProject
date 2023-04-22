CREATE OR ALTER PROCEDURE DMV.CreateDriver
	@FirstName NVARCHAR(32),
	@MiddleName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@DateOfBirth DATE,
	@Sex NCHAR(1),
	@RegisteredDriverID INT OUTPUT
AS

INSERT DMV.RegisteredDrivers(FirstName, MiddleName, LastName, DateOfBirth, Sex)
VALUES(@FirstName, @MiddleName, @LastName, @DateOfBirth, @Sex);

SET @RegisteredDriverID = SCOPE_IDENTITY();
