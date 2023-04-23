CREATE OR ALTER PROCEDURE DMV.AddRegisteredDriversState
	@RegisteredDriverID INT,
	@DLNumber NVARCHAR(20),
	@StateCode NCHAR(2),
	@RegisteredDriversStateID INT OUTPUT
AS

INSERT DMV.RegisteredDriversState(RegisteredDriverID, DLNumber, StateCode)
SELECT M.RegisteredDriverID, M.DLNumber, S.StateCode
FROM
	(
		VALUES (@DLNumber, @StateCode, @RegisteredDriverID)
	) M(DLNumber, StateCode, RegisteredDriverID)
	INNER JOIN DMV.States S ON M.StateCode = S.StateCode;

SET @RegisteredDriversStateID = SCOPE_IDENTITY();