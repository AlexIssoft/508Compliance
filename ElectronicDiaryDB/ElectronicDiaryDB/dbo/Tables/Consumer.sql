CREATE TABLE [dbo].[Consumer] (
    [ConsumerId] BIGINT         IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (128) NOT NULL,
    [LastName]   NVARCHAR (128) NOT NULL,
    [Email]      NVARCHAR (50)  NOT NULL,
    [Birthday]   DATETIME2 (7)  NULL,
    [University] NVARCHAR (256) NULL,
    CONSTRAINT [PK_Consumer] PRIMARY KEY CLUSTERED ([ConsumerId] ASC)
);

