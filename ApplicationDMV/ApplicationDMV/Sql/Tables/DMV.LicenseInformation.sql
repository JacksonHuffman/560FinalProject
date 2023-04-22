IF OBJECT_ID(N'DMV.LicenseInformation') IS NULL
BEGIN
	CREATE TABLE DMV.LicenseInformation
	(
		LicenseID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		RegisteredDriversStateID INT NOT NULL FOREIGN KEY REFERENCES DMV.RegisteredDriversState(RegisteredDriversStateID),
		City NVARCHAR(30) NOT NULL CHECK(City > N''),
		ZIP NCHAR(6) NOT NULL CHECK(ZIP > N''),
		AddressLine1 NVARCHAR(32) NOT NULL CHECK(AddressLine1 > N''),
		AddressLine2 NVARCHAR(32) NULL,
		FeetHeight INT NOT NULL,
		InchesHeight INT NOT NULL,
		[Weight] INT NOT NULL,
		IssueDate DATE NOT NULL,
		ExpDate DATE NOT NULL,
		Class NCHAR(1) NOT NULL,
		IsDonor BIT NOT NULL
	);
END;