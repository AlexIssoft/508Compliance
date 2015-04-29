using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Core.Common;
using Core.Interfaces;
using Core.Models;

namespace Core.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        public LessonModel GetLesson(int lessonId)
        {
            return new LessonModel();
        }

        public List<LessonModel> GetAllLessons()
        {
            var strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            using (var connection = new SqlConnection(strConnString))
            {
                var cmd = new SqlCommand
                 {
                     CommandType = CommandType.StoredProcedure,
                     CommandText = "GetAllLessons",
                     Connection = connection
                 };

                connection.Open();

                var reader = cmd.ExecuteReader();
                var lessons = DataReaderMap.DataReaderMapToList<LessonModel>(reader);
                return lessons;
            }
        }

        public List<LessonModel> GetLessonsByConsumerId(long consumerId)
        {
            var strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            using (var connection = new SqlConnection(strConnString))
            {
                var parameter = new SqlParameter("@consumerId", SqlDbType.BigInt)
                {
                    Value = consumerId
                };

                var cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "GetLessonsByConsumerId",
                    Connection = connection
                };

                cmd.Parameters.Add(parameter);

                connection.Open();

                var reader = cmd.ExecuteReader();
                var lessons = DataReaderMap.DataReaderMapToList<LessonModel>(reader);
                return lessons;
            }
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
