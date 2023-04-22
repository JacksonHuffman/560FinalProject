﻿IF OBJECT_ID(N'DMV.VehicleManufacturer') IS NULL
BEGIN
	CREATE TABLE DMV.VehicleManufacturer
	(
		MakeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		[Name] NVARCHAR(32) NOT NULL UNIQUE
	);
END;