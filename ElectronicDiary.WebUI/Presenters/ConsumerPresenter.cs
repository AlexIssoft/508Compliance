using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ElectronicDiary.WebUI.ViewInterfaces;

namespace ElectronicDiary.WebUI.Presenters
{
    public class ConsumerPresenter
    {
        private readonly IConsumerView _view;
        public ConsumerPresenter(IConsumerView view)
        {
            
            if (view == null)
            {
                throw new ArgumentNullException();
            }
             
            _view = view;
        }

        public void getConsumer(int Id)
        {
            
        }
    }
}