using System.Collections.Generic;
using Core.Models;
using Core.Repositories.Interfaces;

namespace Core.Interfaces
{
    public interface ILessonRepository : IRepository
    {
        LessonModel GetLesson(int lessonId);
        List<LessonModel> GetAllLessons();
        List<LessonModel> GetLessonsByConsumerId(long consumerId);
        void AddLesson(LessonModel lesson);
        void UpdateLesson(LessonModel lesson);
        void RemoveLesson(int lessonId);
    }
}
