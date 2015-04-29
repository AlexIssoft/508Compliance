using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Interfaces;
using Core.Repositories;
using ElectronicDiary.WebUI.ViewInterfaces;
using System.Web.Security;

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

        public void Init()
        {
            var repositoryLocator = new RepositoryLocator();
            var consumerRepository = repositoryLocator.GetRepository<IConsumerRepository>();
            var currentUser = Membership.GetUser();

            _view.Consumer = consumerRepository.GetConsumer(3);
        }
    }
}