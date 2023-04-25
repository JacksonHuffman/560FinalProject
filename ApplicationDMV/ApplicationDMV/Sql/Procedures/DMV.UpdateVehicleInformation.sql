CREATE OR ALTER PROCEDURE DMV.UpdateVehicleInformation
	@VehicleID INT,
	@ModelID INT,
	@VIN NVARCHAR(32),
	@Color NVARCHAR(32),
	@PlateNumber NVARCHAR(10),
	@PolicyNumber NVARCHAR(32),
	@PlateExpDate DATE,
	@PolicyExpDate DATE,
	@InsuranceProvider NVARCHAR(32),
	@Model NVARCHAR(32),
	@Year INT
AS

UPDATE DMV.VehicleInformation
SET
	VIN = @VIN,
	Color = @Color,
	PlateNumber = @PlateNumber,
	PolicyNumber = @PolicyNumber,
	PlateExpDate = @PlateExpDate,
	PolicyExpDate = @PolicyExpDate,
	InsuranceProvider = @InsuranceProvider
WHERE VehicleID = @VehicleID

UPDATE DMV.VehicleModel
SET
	[Name] = @Model,
	[Year] = @Year
WHERE ModelID = @ModelID
