
CREATE PROCEDURE [dbo].[GetLessonsByConsumerId]
@consumerId bigint
AS 
	SET NOCOUNT ON;
  select Lesson.LessonId, Name from Consumer 
  join ConsumerLesson on Consumer.ConsumerId = ConsumerLesson.ConsumerId and .Consumer.ConsumerId = @consumerId
  join Lesson on ConsumerLesson.LessonId = Lesson.LessonId