IF OBJECT_ID(N'DMV.RegisteredDrivers') IS NULL
BEGIN
	CREATE TABLE DMV.RegisteredDrivers
	(
		RegisteredDriverID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		FirstName NVARCHAR(32) NOT NULL CHECK(FirstName > N''),
		MiddleName NVARCHAR(32) NULL,
		LastName NVARCHAR(32) NOT NULL CHECK(LastName > N''),
		DateOfBirth DATE NOT NULL,
		Sex NCHAR(1) NOT NULL
	);
END;

SELECT *
FROM DMV.RegisteredDrivers
