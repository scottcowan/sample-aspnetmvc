using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using TechTalk.SpecFlow;

namespace SampleMVC.Web.AcceptanceTests
{
    [Binding]
    public class WebSteps
    {
        [Given(@"I navigated to the contact page")]
        public void GivenINavigatedToTheContactPage()
        {
            var address = ConfigurationManager.AppSettings["Url"];
            Console.WriteLine(address);
            new WebClient().DownloadString(address);
        }

        [Then(@"I see")]
        public void ThenISee(Table table)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
