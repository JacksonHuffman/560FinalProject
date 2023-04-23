CREATE OR ALTER PROCEDURE DMV.AddRegDriversStateTest
	@RegisteredDriverID INT,
	@DLNumber NVARCHAR(20),
	@StateCode NCHAR(2),
	@RegisteredDriversStateID INT OUTPUT
AS

INSERT DMV.RegisteredDriversState(RegisteredDriverID, DLNumber, StateCode)
VALUES (@RegisteredDriverID, @DLNumber, @StateCode);

SET @RegisteredDriversStateID = SCOPE_IDENTITY();