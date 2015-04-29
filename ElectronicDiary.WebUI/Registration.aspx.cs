using System;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core.Helpers;
using ElectronicDiary.WebUI.Presenters;
using ElectronicDiary.WebUI.ViewInterfaces;

namespace ElectronicDiary.WebUI
{
    public partial class Registration : Page, IRegistrationView
    {
        #region impliment IRegistrationView

        public string UserName
        {
            get { return UserNameField.Text; }
            set { UserNameField.Text = value; }
        }

        public string Password
        {
            get { return PasswordField.Text; }
            set { PasswordField.Text = value; }
        }

        public string EmailAddress
        {
            get { return EmailAddressField.Text; }
            set { EmailAddressField.Text = value; }
        }

        public string FirstName
        {
            get { return FirstNameField.Text; }
            set { FirstNameField.Text = value; }
        }

        public string LastName
        {
            get { return LastNameField.Text; }
            set { LastNameField.Text = value; }
        }

        public DateTime Birthday { get; set; }

        public string University
        {
            get { return UniversityField.Text; }
            set { UniversityField.Text = value; }
        }

        #endregion

        private RegisterPresenter RegisterPresenter { get { return new RegisterPresenter(this);  } }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void formSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    RegisterPresenter.RegistrationConsumer();

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