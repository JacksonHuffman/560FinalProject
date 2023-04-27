CREATE OR ALTER PROCEDURE DMV.GetDLNumber
	@RegisteredDriverID INT,
	@StateCode NCHAR(2)
AS

SELECT RDS.DLNumber
FROM DMV.RegisteredDriversState RDS
WHERE RDS.RegisteredDriverID = @RegisteredDriverID
	AND RDS.StateCode = @StateCode