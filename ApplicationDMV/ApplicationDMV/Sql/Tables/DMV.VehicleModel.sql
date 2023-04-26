IF OBJECT_ID(N'DMV.VehicleModel') IS NULL
BEGIN
	CREATE TABLE DMV.VehicleModel
	(
		ModelID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		MakeID INT NOT NULL FOREIGN KEY REFERENCES DMV.VehicleManufacturer(MakeID),
		[Name] NVARCHAR(32) NOT NULL CHECK([Name] > N''),
		[Year] INT NOT NULL

		UNIQUE
		(
			[Name], 
			[Year]
		)
	);
END;
	
