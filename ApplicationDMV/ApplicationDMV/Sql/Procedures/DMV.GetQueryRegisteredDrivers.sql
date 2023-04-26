CREATE OR ALTER PROCEDURE DMV.GetQueryRegisteredDrivers
	@FirstName NVARCHAR(32) NULL,
	@MiddleName NVARCHAR(32) NULL,
	@LastName NVARCHAR(32) NULL,
	@Sex NCHAR(1) NULL
	--@StateCode NCHAR(2) NULL
AS

SELECT RD.RegisteredDriverID,
	--RDS.RegisteredDriversStateID,
	RD.FirstName,
	RD.MiddleName,
	RD.LastName,
	RD.Sex,
	RD.DateOfBirth
	--RDS.StateCode,
	--RDS.DLNumber
FROM DMV.RegisteredDrivers RD
	--INNER JOIN DMV.RegisteredDriversState RDS ON RD.RegisteredDriverID = RDS.RegisteredDriverID
WHERE RD.FirstName LIKE IIF(@FirstName IS NULL, '%', @FirstName)
	AND RD.MiddleName LIKE IIF(@MiddleName IS NULL, '%', @MiddleName)
	AND RD.LastName LIKE IIF(@LastName IS NULL, '%', @LastName)
	AND RD.Sex LIKE IIF(@Sex IS NULL, '%', @Sex)
	--AND RDS.StateCode LIKE IIF(@StateCode IS NULL, '%', @StateCode)