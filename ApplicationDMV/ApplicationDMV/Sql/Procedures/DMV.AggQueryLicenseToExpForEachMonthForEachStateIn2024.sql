CREATE OR ALTER PROCEDURE DMV.AggQueryLicenseToExpForEachMonthForEachStateIn2024
	@Year INT
AS

SELECT MONTH(L.ExpDate) AS MonthOf2024,
	RDS.StateCode,
	COUNT(L.LicenseID) AS LicensesToExp
FROM DMV.RegisteredDrivers RD
	INNER JOIN DMV.RegisteredDriversState RDS ON RDS.RegisteredDriverID = RD.RegisteredDriverID
	INNER JOIN DMV.LicenseInformation L ON L.RegisteredDriversStateID = RDS.RegisteredDriversStateID
WHERE YEAR(L.ExpDate) = @Year
GROUP BY MONTH(L.ExpDate), RDS.StateCode
ORDER BY MonthOf2024 ASC
