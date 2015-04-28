using System;
using System.Web.Security;
using System.Web.UI;
using ElectronicDiary.WebUI.Presenters;
using ElectronicDiary.WebUI.ViewInterfaces;

namespace ElectronicDiary.WebUI
{
    public partial class HomePage : Page, IHomeView
    {
        public string FileName { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //MembershipCreateStatus status;
            //Membership.CreateUser("TestUser", "qWaszx12!", "qwe@qwe.ru", "qwe", "qwe", true, out status);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var presenter = new HomePresenter(this);
            
            Response.Redirect(FileName);
        }
    }
}