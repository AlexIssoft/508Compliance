using Core.Models;
using System.Collections.Generic;

namespace ElectronicDiary.WebUI.ViewInterfaces
{
    public interface IAddLessonView
    {
        List<LessonModel> Lessons { get; set; }
        List<LessonModel> ConsumerLessons { get; set; }
    }
}