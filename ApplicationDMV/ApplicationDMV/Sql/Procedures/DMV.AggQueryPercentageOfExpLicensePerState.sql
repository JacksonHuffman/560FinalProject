SELECT RDS.StateCode,
	COUNT(*) AS LicenseCount,
	SUM(IIF(L.ExpDate < SYSDATETIMEOFFSET(),1,0)) AS ExpLicenseCount, 
	((SUM(IIF(L.ExpDate < SYSDATETIMEOFFSET(),1,0)))/(COUNT(*)))*100 AS PecentageExpired
FROM DMV.RegisteredDriversState RDS
	INNER JOIN DMV.LicenseInformation L ON L.RegisteredDriversStateID = RDS.RegisteredDriversStateID
GROUP BY RDS.StateCode
ORDER BY PecentageExpired DESC
