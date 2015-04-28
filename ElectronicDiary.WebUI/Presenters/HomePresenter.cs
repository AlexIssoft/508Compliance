using System;
using ElectronicDiary.WebUI.ViewInterfaces;

namespace ElectronicDiary.WebUI.Presenters
{
    public class HomePresenter
    {
        private readonly IHomeView _view;

        public HomePresenter(IHomeView view)
        {
            if (view == null)
            {
                throw new ArgumentNullException();
            }
            _view = view;
        }

        public void CheckUser(string test)
        {
            _view.FileName = "/Secure/Home.aspx";
        }
    }
}