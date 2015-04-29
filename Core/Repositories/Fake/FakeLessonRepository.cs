using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;

namespace Core.Repositories.Fake
{
    class FakeLessonRepository : BaseFakeRepository<LessonModel>, ILessonRepository
    {
        public FakeLessonRepository()
        {
            FakeData = new Dictionary<long, LessonModel>
            {
                {
                    1, new LessonModel
                    {
                        LessonId = 1,
                        Name = "History"
                    }
                },
                {
                    2, new LessonModel
                    {
                        LessonId = 2,
                        Name = "Biology"
                    }
                },
                {
                    3, new LessonModel
                    {
                        LessonId = 3,
                        Name = "Mathematics"
                    }
                }
            };
        }

        public LessonModel GetLesson(int lessonId)
        {
           return Get(lessonId);
        }

        public List<LessonModel> GetAllLessons()
        {
            return GetAll();
        }

        public List<LessonModel> GetLessonsByConsumerId(long consumerId)
        {
            throw new System.NotImplementedException();
        }

        public void AddLesson(LessonModel lesson)
        {
            Add(lesson);
        }

        public void UpdateLesson(LessonModel lesson)
        {
            FakeData[lesson.LessonId] = lesson;
        }

        public void RemoveLesson(int lessonId)
        {
            Delete(lessonId);
        }
    }
}
