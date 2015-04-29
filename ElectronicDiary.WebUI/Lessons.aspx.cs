using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core.Models;
using ElectronicDiary.WebUI.Presenters;
using ElectronicDiary.WebUI.ViewInterfaces;

namespace ElectronicDiary.WebUI
{
    public partial class Lessons : Page, ILessonsView
    {
        public List<LessonModel> Lessons { get; set; }
        public List<LessonModel> ConsumerLessons { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            new LessonsPresenter(this).Init();
            if (!IsPostBack)
            {
                foreach (var lesson in Lessons)
                {
                    CheckBoxListLessons.Items.Add(new ListItem
                     {
                         Value = lesson.LessonId.ToString(),
                         Text = lesson.Name,
                         Selected = ConsumerLessons.FirstOrDefault(x => x.LessonId == lesson.LessonId) != null
                     });
                }
            }
        }

        protected void ChangeListLessonsBtn_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxListLessons.Items)
            {
                var exist = ConsumerLessons.Any(x => x.LessonId == Convert.ToInt32(item.Value));

                if (item.Selected)
                {
                    if (!exist)
                    {

                    }
                }
                else
                {
                    if (exist)
                    {

                    }
                }
            }
        }
    }
}