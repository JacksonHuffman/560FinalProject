CREATE OR ALTER PROCEDURE DMV.AggQueryPercentageOfExpLicensePerState
	@TodayDate DATE
AS

SELECT RDS.StateCode,
	COUNT(L.LicenseID) AS LicenseCount,
	SUM(IIF(L.ExpDate < @TodayDate,1,0)) AS ExpLicenseCount,
	ROUND((CAST(SUM(IIF(L.ExpDate < @TodayDate,1,0)) AS DECIMAL(5,2)) / COUNT(L.LicenseID) * 100), 2) AS PercentageExpired
FROM DMV.RegisteredDriversState RDS
	INNER JOIN DMV.LicenseInformation L ON L.RegisteredDriversStateID = RDS.RegisteredDriversStateID
GROUP BY RDS.StateCode
ORDER BY PercentageExpired DESC