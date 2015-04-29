using System;
using System.Web.Security;

namespace ElectronicDiary.WebUI
{
    public partial class Login : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void formSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (Membership.ValidateUser(UserName.Text, Password.Text))
                {
                    FormsAuthentication.RedirectFromLoginPage (UserName.Text, SaveMe.Checked);
                    Response.Redirect(Request.QueryString["ReturnUrl"] ?? "~/");
                }
                else
                {
                    Msg.Text = "Invalid credentials. Please try again.";
                }
            }
        }
    }
}