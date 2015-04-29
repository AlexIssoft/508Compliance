using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ElectronicDiary.WebUI.Presenters;
using ElectronicDiary.WebUI.ViewInterfaces;
using Core.Repositories.Fake;


namespace ElectronicDiary.WebUI
{
    public partial class ConsumerProfiler : Page, IConsumerView
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var presenter = new ConsumerPresenter(this);
            var repositoryLocator = new FakeConsumerRepository();
            var Consumer = repositoryLocator.GetConsumer(3);



        }
    }
}