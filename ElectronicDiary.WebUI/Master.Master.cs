using System;
using System.Web.Security;
using System.Web.UI;

namespace ElectronicDiary.WebUI
{
    public partial class Master : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/Login.aspx");
        }

    }
}