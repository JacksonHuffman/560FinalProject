CREATE OR ALTER PROCEDURE DMV.GetModelID
	@Name NVARCHAR(32),
	@Year INT
AS

SELECT M.ModelID
FROM DMV.VehicleModel M
WHERE M.[Name] = @Name
	AND M.[Year] = @Year