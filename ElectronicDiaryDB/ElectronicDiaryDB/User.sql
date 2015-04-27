GO
CREATE LOGIN [ElectronicDiary] WITH PASSWORD=N'123123', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

GO
CREATE USER [ElectronicDiary] FOR LOGIN [ElectronicDiary]
GO

GO
EXEC sp_addrolemember N'db_owner', N'ElectronicDiary'
GO