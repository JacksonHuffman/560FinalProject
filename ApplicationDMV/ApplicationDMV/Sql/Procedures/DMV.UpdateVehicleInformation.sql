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

WITH MergeInformationCte(VehicleID, VIN, Color, PlateNumber, PolicyNumber, PlateExpDate, PolicyExpDate, InsuranceProvider) AS
	(
		SELECT M.VehicleID,
			M.VIN,
			M.Color,
			M.PlateNumber,
			M.PolicyNumber,
			M.PlateExpDate,
			M.PolicyExpDate,
			M.InsuranceProvider
		FROM
			(
				VALUES(@VehicleID, @VIN, @Color, @PlateNumber, @PolicyNumber, @PlateExpDate, @PolicyExpDate, @InsuranceProvider)
			) M(VehicleID, VIN, Color, PlateNumber, PolicyNumber, PlateExpDate, PolicyExpDate, InsuranceProvider)
	)
MERGE DMV.VehicleInformation V
USING MergeInformationCte S ON S.VehicleID = V.VehicleID
WHEN MATCHED THEN
UPDATE
SET
	VIN = S.VIN,
	Color = S.Color,
	PlateNumber = S.PlateNumber,
	PolicyNumber = S.PolicyNumber,
	PlateExpDate = S.PlateExpDate,
	PolicyExpDate = S.PolicyExpDate,
	InsuranceProvider = S.InsuranceProvider;

WITH MergeModelCte(Model, [Year], ModelID) AS
	(
		SELECT M.Model,
			M.[Year],
			M.ModelID
		FROM
			(
				VALUES(@Model, @Year, @ModelID)
			) M(Model, [Year], ModelID)
	)
MERGE DMV.VehicleModel VM
USING MergeModelCte SM ON SM.ModelID = VM.ModelID
WHEN MATCHED THEN
UPDATE
SET
	[Name] = SM.Model,
	[Year] = SM.[Year];

