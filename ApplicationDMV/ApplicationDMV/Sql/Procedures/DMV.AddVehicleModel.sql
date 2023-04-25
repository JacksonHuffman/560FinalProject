CREATE OR ALTER PROCEDURE DMV.AddVehicleModel
	@MakeID INT,
	@Name NVARCHAR(32),
	@Year SMALLINT,
	@ModelID INT OUTPUT
AS

INSERT DMV.VehicleModel(MakeID, [Name], [Year])
SELECT M.MakeID, M.[Name], M.[Year]
FROM
	(
		VALUES(@MakeID, @Name, @Year)
	) M(MakeID, [Name], [Year])
	INNER JOIN DMV.VehicleManufacturer VMF ON M.MakeID = VMF.MakeID;

SET @ModelID = SCOPE_IDENTITY();
