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

WITH MergeCte(LicenseID, City, ZIP, AddressLine1, AddressLine2, FeetHeight, InchesHeight, [Weight], IssueDate, ExpDate, Class, IsDonor) AS
	(
		SELECT M.LicenseID,
			M.City,
			M.ZIP,
			M.AddressLine1,
			M.AddressLine2,
			M.FeetHeight,
			M.InchesHeight,
			M.[Weight],
			M.IssueDate,
			M.ExpDate,
			M.Class,
			M.IsDonor
		FROM
			(
				VALUES(@LicenseID, @City, @ZIP, @AddressLine1, @AddressLine2, @FeetHeight, @InchesHeight, @Weight, @IssueDate, @ExpDate, @Class, @IsDonor)
			) M(LicenseID, City, ZIP, AddressLine1, AddressLine2, FeetHeight, InchesHeight, [Weight], IssueDate, ExpDate, Class, IsDonor)
	)
MERGE DMV.LicenseInformation L
USING MergeCte S ON S.LicenseID = L.LicenseID
WHEN MATCHED THEN
UPDATE 
SET
	City = S.City,
	ZIP = S.ZIP,
	AddressLine1 = S.AddressLine1,
	AddressLine2 = S.AddressLine2,
	FeetHeight = S.FeetHeight,
	InchesHeight = S.InchesHeight,
	[Weight] = S.[Weight],
	IssueDate = S.IssueDate,
	ExpDate = S.ExpDate,
	Class = S.Class,
	IsDonor = S.IsDonor;