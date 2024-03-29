﻿CREATE OR ALTER PROCEDURE DMV.GetQueryVehicleInformation
	@VIN NVARCHAR(32),
	@Color NVARCHAR(32),
	@PlateNumber NVARCHAR(6),
	@PolicyNumber NVARCHAR(32),
	@InsuranceProvider NVARCHAR(32),
	@MakeName NVARCHAR(32),
	@ModelName NVARCHAR(32),
	@Year INT
AS

WITH Cte(VehicleID, VIN, RegisteredDriverID, ModelID, Color, PlateNumber, PolicyNumber, PlateExpDate, PolicyExpDate, InsuranceProvider) AS
	(
		SELECT V.VehicleID,
			V.VIN,
			V.RegisteredDriverID,
			V.ModelID,
			V.Color,
			V.PlateNumber,
			V.PolicyNumber,
			V.PlateExpDate,
			V.PolicyExpDate,
			V.InsuranceProvider
		FROM DMV.VehicleInformation V
		WHERE V.VIN LIKE IIF (@VIN IS NULL, '%', @VIN)
			AND V.Color LIKE IIF(@Color IS NULL, '%', @Color)
			AND V.PlateNumber LIKE IIF(@PlateNumber IS NULL, '%', @PlateNumber)
			AND V.PolicyNumber LIKE IIF(@PolicyNumber IS NULL, '%', @PolicyNumber)
			and V.InsuranceProvider LIKE IIF(@InsuranceProvider IS NULL, '%', @InsuranceProvider)
		)
SELECT C.VehicleID,
	C.RegisteredDriverID,
	C.ModelID,
	VMF.MakeID,
	RD.FirstName,
	RD.MiddleName,
	RD.LastName,
	VM.[Year],
	C.Color,
	VMF.[Name] AS Manufacturer,
	VM.[Name] AS Model,
	C.VIN,
	C.PlateNumber,
	C.PolicyNumber,
	C.PlateExpDate,
	C.PolicyExpDate,
	C.InsuranceProvider
FROM Cte C
	INNER JOIN DMV.VehicleModel VM ON C.ModelID = VM.ModelID
	INNER JOIN DMV.VehicleManufacturer VMF	ON VMF.MakeID = VM.MakeID
	INNER JOIN DMV.RegisteredDrivers RD ON RD.RegisteredDriverID = C.RegisteredDriverID
WHERE VMF.[Name] LIKE IIF(@MakeName IS NULL, '%', @MakeName)
	AND VM.[Name] LIKE IIF(@ModelName IS NULL, '%', @ModelName)
	AND VM.[Year] LIKE IIF(CONVERT(NVARCHAR(10) ,@Year) IS NULL, '%', CONVERT(NVARCHAR(10) , @Year))
