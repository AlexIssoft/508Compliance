using System;
using ElectronicDiary.WebUI.Presenters;
using ElectronicDiary.WebUI.ViewInterfaces;

namespace ElectronicDiary.WebUI
{
    public partial class HomePage : BasePage, IHomeView
    {
        public string FileName { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            new HomePresenter(this);
            Response.Redirect(FileName);
        }
    }
}