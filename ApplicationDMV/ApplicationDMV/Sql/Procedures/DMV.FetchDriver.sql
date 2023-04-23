CREATE OR ALTER PROCEDURE DMV.FetchDriver
	@RegisteredDriverID INT
AS

SELECT RD.RegisteredDriverID,
	RD.FirstName,
	RD.MiddleName,
	RD.LastName,
	RD.DateOfBirth,
	RD.Sex
FROM DMV.RegisteredDrivers RD
WHERE RD.RegisteredDriverID = @RegisteredDriverID
