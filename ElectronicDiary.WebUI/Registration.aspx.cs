using System;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core.Helpers;

namespace ElectronicDiary.WebUI
{
    public partial class Registration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void formSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    Membership.CreateUser(UserName.Text, Password.Text, EmailAddress.Text);
                    Response.Redirect("login.aspx");
                }
                catch (MembershipCreateUserException erorMessage) 
                {
                    Msg.Text = erorMessage.Message;
                }
            }
        }

        protected void EmailAddrHasValidFormat_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = EmailHelper.IsEmailValid(args.Value);
        }

    }
}