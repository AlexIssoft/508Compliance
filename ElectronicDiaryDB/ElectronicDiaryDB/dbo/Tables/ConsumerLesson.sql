CREATE TABLE [dbo].[ConsumerLesson] (
    [ConsumerLessonId] BIGINT IDENTITY (1, 1) NOT NULL,
    [ConsumerId]       BIGINT NOT NULL,
    [LessonId]         BIGINT NOT NULL,
    CONSTRAINT [PK_ConsumerLesson] PRIMARY KEY CLUSTERED ([ConsumerLessonId] ASC),
    CONSTRAINT [FK_ConsumerLesson_Consumer] FOREIGN KEY ([ConsumerId]) REFERENCES [dbo].[Consumer] ([ConsumerId]),
    CONSTRAINT [FK_ConsumerLesson_Lesson] FOREIGN KEY ([LessonId]) REFERENCES [dbo].[Lesson] ([LessonId])
);

