using System.Web.Security;
using ElectronicDiary.WebUI.ViewInterfaces;

namespace ElectronicDiary.WebUI.Presenters
{
    public class RegisterPresenter
    {
        private readonly IRegistrationView _view;

        public RegisterPresenter(IRegistrationView view)
        {
            _view = view;
        }

        public void RegistrationConsumer()
        {
            var user = Membership.CreateUser(_view.UserName, _view.Password, _view.EmailAddress);
        }
    }
}