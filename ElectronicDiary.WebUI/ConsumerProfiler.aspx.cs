using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using Core.Models;
using ElectronicDiary.WebUI.Presenters;
using ElectronicDiary.WebUI.ViewInterfaces;


namespace ElectronicDiary.WebUI
{
    public partial class ConsumerProfiler : Page, IConsumerView
    {
        public ConsumerModel Consumer { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            new ConsumerPresenter(this).Init();

            if (!IsPostBack)
            {
                 LastName.Text = Consumer.LastName;
                 FirstName.Text = Consumer.FirstName;
                 Email.Text = Consumer.Email;                 
                 BirthDate.Text = Convert.ToString(Consumer.BirthDate);
                 University.Text = Consumer.University;                

            }
        }
    }
}