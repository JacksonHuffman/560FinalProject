CREATE OR ALTER PROCEDURE DMV.AddVehicleInformation
	@VIN NVARCHAR(32),
	@RegisteredDriverID INT,
	@ModelID INT,
	@Color NVARCHAR(32),
	@PlateNumber NVARCHAR(6),
	@PolicyNumber NVARCHAR(32),
	@PolicyExpDate DATE,
	@PlateExpDate DATE,
	@InsuranceProvider NVARCHAR(32),
	@VehicleID INT OUTPUT
AS

INSERT DMV.VehicleInformation(VIN, RegisteredDriverID, ModelID, Color, PlateNumber, PolicyNumber, PolicyExpDate, PlateExpDate, InsuranceProvider)
SELECT M.VIN, RD.RegisteredDriverID, VMD.ModelID, M.Color, M.PlateNumber, M.PolicyNumber, M.PolicyExpDate, M.PlateExpDate, M.InsuranceProvider
FROM
	(
		VALUES (@VIN, @RegisteredDriverID, @ModelID, @Color, @PlateNumber, @PolicyNumber, @PolicyExpDate, @PlateExpDate, @InsuranceProvider)
	) M(VIN, RegisteredDriverID, ModelID, Color, PlateNumber, PolicyNumber, PolicyExpDate, PlateExpDate, InsuranceProvider)
	INNER JOIN DMV.RegisteredDrivers RD ON M.RegisteredDriverID = RD.RegisteredDriverID
	INNER JOIN DMV.VehicleModel VMD ON M.ModelID = VMD.ModelID

SET @VehicleID = SCOPE_IDENTITY();