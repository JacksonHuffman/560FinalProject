IF OBJECT_ID(N'DMV.VehicleInformation') IS NULL
BEGIN
	CREATE TABLE DMV.VehicleInformation
	(
		VehicleID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		VIN INT NOT NULL,
		RegisteredDriverID INT NOT NULL FOREIGN KEY REFERENCES DMV.RegisteredDrivers(RegisteredDriverID),
		ModelID INT NOT NULL FOREIGN KEY REFERENCES DMV.VehicleModel(ModelID),
		Color NVARCHAR(32) NOT NULL CHECK(Color > N''),
		PlateNumber NVARCHAR(6) NOT NULL CHECK(PlateNumber > N''),
		PolicyNumber NVARCHAR(32) NOT NULL CHECK(PolicyNumber > N''),
		PlateExpDate DATE NOT NULL,
		PolicyExpDate DATE NOT NULL,
		InsuranceProvider NVARCHAR(32) NOT NULL CHECK(InsuranceProvider > N'')

		UNIQUE
		(
			PlateNumber,
			PolicyNumber
		)
	);
END;