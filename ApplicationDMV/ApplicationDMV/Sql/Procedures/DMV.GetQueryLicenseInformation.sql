CREATE OR ALTER PROCEDURE DMV.GetQueryLicenseInformation
	@DLNumber NVARCHAR(30),
	@StateCode NCHAR(2),
	@City NVARCHAR(32),
	@ZIP NCHAR(6),
	@AddressLine1 NVARCHAR(32),
	@AddressLine2 NVARCHAR(32),
	@FeetHeight INT,
	@InchesHeight INT,
	@Weight INT,
	@Class NCHAR(1)
AS

--DECLARE @DLNumber NVARCHAR(32) = NULL
--DECLARE @StateCode NCHAR(2) = NULL
--DECLARE @City NVARCHAR(32) = NULL
--DECLARE @ZIP NCHAR(5) = '64834'
--DECLARE @AddressLine1 NVARCHAR(32) = NULL
--DECLARE @AddressLine2 NVARCHAR(32) = NULL
--DECLARE @FeetHeight INT = NULL
--DECLARE @InchesHeight INT = NULL
--DECLARE @Weight INT = NULL
--DECLARE @Class NCHAR(1) = NULL

SELECT L.LicenseID,
	RD.RegisteredDriverID,
	RDS.RegisteredDriversStateID,
	RDS.StateCode,
	L.City,
	L.ZIP,
	L.AddressLine1,
	L.AddressLine2,
	L.FeetHeight,
	L.InchesHeight,
	L.[Weight],
	L.ExpDate,
	L.IssueDate,
	L.Class,
	L.IsDonor,
	RD.FirstName,
	RD.MiddleName,
	RD.LastName,
	RDS.DLNumber
FROM dbo.[DMV.RegisteredDrivers] RD
	INNER JOIN DMV.RegisteredDriversState RDS ON RDS.RegisteredDriverID = RD.RegisteredDriverID
	INNER JOIN DMV.LicenseInformation L ON L.RegisteredDriversStateID = RDS.RegisteredDriversStateID
WHERE RDS.DLNumber LIKE IIF(@DLNumber IS NULL, '%', @DLNumber)
	AND RDS.StateCode LIKE IIF(@StateCode IS NULL, '%', @StateCode)
	AND L.City LIKE IIF(@City IS NULL, '%', @City)
	AND L.ZIP LIKE IIF(@ZIP IS NULL, '%', @ZIP)
	AND L.AddressLine1 LIKE IIF(@AddressLine1 IS NULL, '%', @AddressLine1)
	AND L.AddressLine2 LIKE IIF(@AddressLine2 IS NULL, '%', @AddressLine2)
	AND L.FeetHeight LIKE IIF(CONVERT(NVARCHAR(10), @FeetHeight) IS NULL, '%', CONVERT(NVARCHAR(10), @FeetHeight))
	AND L.InchesHeight LIKE IIF(CONVERT(NVARCHAR(10), @InchesHeight) IS NULL, '%', CONVERT(NVARCHAR(10), @InchesHeight))
	AND L.[Weight] LIKE IIF(CONVERT(NVARCHAR(10), @Weight) IS NULL, '%', CONVERT(NVARCHAR(10), @Weight))
	AND L.Class LIKE IIF(@Class IS NULL, '%', @Class)