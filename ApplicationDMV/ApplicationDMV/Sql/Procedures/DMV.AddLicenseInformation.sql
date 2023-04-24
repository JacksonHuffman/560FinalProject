CREATE OR ALTER PROCEDURE DMV.AddLicenseInformation
	@RegisteredDriversStateID INT,
	@City NVARCHAR(30),
	@ZIP NCHAR(5),
	@AddressLine1 NVARCHAR(32),
	@AddressLine2 NVARCHAR(32) NULL,
	@FeetHeight INT,
	@InchesHeight INT,
	@Weight INT,
	@IssueDate DATE,
	@ExpDate DATE,
	@Class NCHAR(1),
	@IsDonor BIT,
	@LicenseID INT OUTPUT
AS

INSERT DMV.LicenseInformation(RegisteredDriversStateID, City, ZIP, AddressLine1, AddressLine2, FeetHeight, InchesHeight, [Weight], IssueDate, ExpDate, Class, IsDonor)
VALUES (@RegisteredDriversStateId, @City, @ZIP, @AddressLine1, @AddressLine2, @FeetHeight, @InchesHeight, @Weight, @IssueDate, @ExpDate, @Class, @IsDonor);

SET @LicenseID = SCOPE_IDENTITY();