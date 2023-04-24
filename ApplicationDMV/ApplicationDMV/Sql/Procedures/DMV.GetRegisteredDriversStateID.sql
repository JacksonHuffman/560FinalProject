CREATE OR ALTER PROCEDURE DMV.GetRegisteredDriversStateID
	@RegisteredDriverID INT,
	@StateCode NCHAR(2)
AS

SELECT RDS.RegisteredDriversStateID
FROM DMV.RegisteredDriversState RDS
	INNER JOIN DMV.States S ON RDS.StateCode = S.StateCode
WHERE RDS.RegisteredDriverID = @RegisteredDriverID
	AND S.StateCode = @StateCode
