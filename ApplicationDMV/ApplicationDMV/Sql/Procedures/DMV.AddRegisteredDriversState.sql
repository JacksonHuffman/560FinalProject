CREATE OR ALTER PROCEDURE AddRegisteredDriversState
	@FirstName NVARCHAR(32),
	@MiddleName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@DateOfBirth DATE,
	@DLNumber NVARCHAR(20),
	@RegisteredDriverID INT,
	@StateCode NCHAR(2),
	@RegisteredDriversStateID INT OUTPUT
AS

INSERT DMV.RegisteredDriversState(DLNumber, RegisteredDriverID, StateCode)
SELECT M.DLNumber, RD.RegisteredDriverID, S.StateCode
FROM
		(
			VALUES (@FirstName, @MiddleName, @LastName, @DateOfBirth, @DLNumber, @StateCode)
		) M(FirstName, MiddleName, LastName, DateOfBirth, DLNumber, StateCode)
	INNER JOIN DMV.RegisteredDrivers RD ON M.FirstName = RD.FirstName
		AND M.MiddleName = RD.MiddleName
		AND M.LastName = RD.LastName
		AND M.DateOfBirth = RD.DateOfBirth
	INNER JOIN DMV.States S ON M.StateCode = S.StateCode

SET @RegisteredDriversStateID = SCOPE_IDENTITY()
	