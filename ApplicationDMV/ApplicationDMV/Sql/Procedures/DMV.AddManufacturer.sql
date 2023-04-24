﻿CREATE OR ALTER PROCEDURE DMV.AddManufacturer
	@Name NVARCHAR(32),
	@MakeID INT OUTPUT
AS

INSERT DMV.VehicleManufacturer([Name])
VALUES (@Name);

SET @MakeID = SCOPE_IDENTITY();
