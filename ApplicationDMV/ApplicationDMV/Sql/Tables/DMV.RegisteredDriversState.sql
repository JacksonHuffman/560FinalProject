IF OBJECT_ID(N'DMV.RegisteredDriversState') IS NULL
BEGIN
	CREATE TABLE DMV.RegisteredDriversState
	(
		RegisteredDriversStateID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		DLNumber NVARCHAR(20) NOT NULL CHECK(DLNumber > N''),
		RegisteredDriverID INT NOT NULL FOREIGN KEY REFERENCES DMV.RegisteredDrivers(RegisteredDriverID),
		StateCode NCHAR(2) NOT NULL FOREIGN KEY REFERENCES DMV.States(StateCode)

		UNIQUE
		(
			DLNumber,
			RegisteredDriverID,
			StateCode
		)
	);
END;
