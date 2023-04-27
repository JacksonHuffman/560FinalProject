CREATE OR ALTER PROCEDURE DMV.UpdateLicenseInformation
	@LicenseID INT,
	@City NVARCHAR(32),
	@ZIP NCHAR(5),
	@AddressLine1 NVARCHAR(32),
	@AddressLine2 NVARCHAR(32),
	@FeetHeight INT,
	@InchesHeight INT,
	@Weight INT,
	@IssueDate DATE,
	@ExpDate DATE,
	@Class NCHAR(1),
	@IsDonor BIT
AS

UPDATE DMV.LicenseInformation
SET
	City = @City,
	ZIP = @ZIP,
	AddressLine1 = @AddressLine1,
	AddressLine2 = AddressLine2,
	FeetHeight = @FeetHeight,
	InchesHeight = @InchesHeight,
	[Weight] = @Weight,
	IssueDate = @IssueDate,
	ExpDate = @ExpDate,
	Class = @Class,
	IsDonor = @IsDonor
WHERE LicenseID = @LicenseID