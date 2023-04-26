IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'DMV'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [DMV] AUTHORIZATION [dbo]');
END;