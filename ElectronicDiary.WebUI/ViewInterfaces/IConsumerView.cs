using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Models;

namespace ElectronicDiary.WebUI.ViewInterfaces
{
    public interface IConsumerView
    {
        ConsumerModel Consumer { get; set; }
    }
}