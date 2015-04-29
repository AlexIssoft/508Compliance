CREATE PROCEDURE [dbo].[GetAllLessons]
    
AS 
	SET NOCOUNT ON;
    SELECT LessonId, Name FROM Lesson