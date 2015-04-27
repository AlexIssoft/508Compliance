CREATE TABLE [dbo].[Lesson] (
    [LessonId] BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Lesson] PRIMARY KEY CLUSTERED ([LessonId] ASC)
);

