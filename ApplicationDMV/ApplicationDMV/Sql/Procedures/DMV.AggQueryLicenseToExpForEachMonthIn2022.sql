SELECT MONTH(L.ExpDate) AS MonthOf2023,
	RDS.StateCode,
	COUNT(L.LicenseID) AS LicensesToExp
FROM DMV.RegisteredDrivers RD
	INNER JOIN DMV.RegisteredDriversState RDS ON RDS.RegisteredDriverID = RD.RegisteredDriverID
	INNER JOIN DMV.LicenseInformation L ON L.RegisteredDriversStateID = RDS.RegisteredDriversStateID
WHERE L.ExpDate BETWEEN '01/01/2023' AND '12/31/2023'
GROUP BY MONTH(L.ExpDate), RDS.StateCode
ORDER BY MonthOf2023 ASC
