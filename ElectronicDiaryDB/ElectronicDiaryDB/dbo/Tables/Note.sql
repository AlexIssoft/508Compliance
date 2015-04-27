CREATE TABLE [dbo].[Note] (
    [NoteId]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [ConsumerId] BIGINT        NOT NULL,
    [LessonId]   BIGINT        NOT NULL,
    [Grade]      INT           NOT NULL,
    [CreateDate] DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Note] PRIMARY KEY CLUSTERED ([NoteId] ASC),
    CONSTRAINT [FK_Note_Consumer] FOREIGN KEY ([ConsumerId]) REFERENCES [dbo].[Consumer] ([ConsumerId]),
    CONSTRAINT [FK_Note_Lesson] FOREIGN KEY ([LessonId]) REFERENCES [dbo].[Lesson] ([LessonId])
);

