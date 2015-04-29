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
    public partial class AddLesson : Page, IAddLessonView
    {
        public List<LessonModel> Lessons { get; set; }
        public List<LessonModel> ConsumerLessons { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            new AddLessonPresenter(this).Init();
            if (!IsPostBack)
            {
                foreach (var lesson in Lessons)
                {
                    if (ConsumerLessons.FirstOrDefault(x => x.LessonId == lesson.LessonId) != null)
                    {
                        CheckBoxListConsumerLessons.Items.Add(new ListItem
                        {
                            Value = lesson.LessonId.ToString(),
                            Text = lesson.Name,
                            Selected = true
                        });
                    }
                    else
                    {
                        CheckBoxListUnselectedLessons.Items.Add(new ListItem
                        {
                            Value = lesson.LessonId.ToString(),
                            Text = lesson.Name,
                            Selected = false
                        });
                    }
                }
            }
        }

        protected void ChangeListLessonsBtn_Click(object sender, EventArgs e)
        {
            foreach (ListItem listItem in CheckBoxListConsumerLessons.Items)
            {
                if (!listItem.Selected)
                {
                    
                }
            }

            foreach (ListItem listItem in CheckBoxListUnselectedLessons.Items)
            {
                if (listItem.Selected)
                {

                }
            }
        }
    }
}