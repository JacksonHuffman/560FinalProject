CREATE OR ALTER PROCEDURE DMV.AggQueryInsuranceProviderForMenInKansas
	@Sex NCHAR(1),
	@StateCode NCHAR(2)
AS

SELECT V.InsuranceProvider,
	COUNT(DISTINCT RD.RegisteredDriverID) AS MenInsured
FROM DMV.RegisteredDrivers RD
	INNER JOIN DMV.VehicleInformation V ON V.RegisteredDriverID = RD.RegisteredDriverID
	INNER JOIN DMV.RegisteredDriversState RDS ON RDS.RegisteredDriverID = RD.RegisteredDriverID
WHERE RD.Sex = @Sex
	AND RDS.StateCode = @StateCode
GROUP BY V.InsuranceProvider
ORDER BY MenInsured DESC
