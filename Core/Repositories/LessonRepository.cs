using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;

namespace Core.Repositories
{
    public class LessonRepository: ILessonRepository
    {
        public LessonModel GetLesson(int lessonId)
        {
            return new LessonModel();
        }

        public List<LessonModel> GetAllLessons()
        {
            return new List<LessonModel>();
        }

        public void AddLesson(LessonModel lesson)
        {
            
        }

        public void UpdateLesson(LessonModel lesson)
        {
            lesson.Name = "newName";
        }

        public void RemoveLesson(int lessonId)
        {
            
        }
    }
}
