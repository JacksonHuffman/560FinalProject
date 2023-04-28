CREATE OR ALTER PROCEDURE DMV.AggQueryTopFiveMostPopularVehiclesAmongstFemales
	@Sex NCHAR(1)
AS 

SELECT TOP (5) VM.[Year],
	VMF.[Name] AS Manufacturer,
	VM.[Name],
	COUNT(DISTINCT VM.ModelID) AS NumberOfFemaleOwners
FROM DMV.RegisteredDrivers RD
	INNER JOIN DMV.VehicleInformation VI ON VI.RegisteredDriverID = RD.RegisteredDriverID
	INNER JOIN DMV.VehicleModel VM ON VM.ModelID = VI.ModelID
	INNER JOIN DMV.VehicleManufacturer VMF ON VMF.MakeID = VM.MakeID
WHERE RD.Sex = @Sex
GROUP BY VM.[Name], VM.[Year], VMF.[Name]
ORDER BY NumberOfFemaleOwners DESC
