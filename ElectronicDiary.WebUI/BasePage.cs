using System;
using System.Web.Security;
using System.Web.UI;
using Core.Interfaces;
using Core.Models;
using Core.Repositories;

namespace ElectronicDiary.WebUI
{
    public class BasePage : Page
    {
        public ConsumerModel Consumer
        {
            get
            {
                if ((ConsumerModel) Session["Consumer"] == null)
                {
                    Session["Consumer"] = SetConsumer();
                }
                return (ConsumerModel)Session["Consumer"];
            }
            set { Session["Consumer"] = value; }
        }

        private static ConsumerModel SetConsumer()
        {
            var repositoryLocator = new RepositoryLocator();
            return repositoryLocator.GetRepository<IConsumerRepository>().GetConsumerByUserId((Guid)Membership.GetUser().ProviderUserKey);
        }
    }
}