using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
  
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using TechTalk.SpecFlow.Assist;
using System.Configuration;

namespace SpeckflowTest.Steps
{
    class Search_Risk_Management
    {
        IWebDriver currentdriver = null;
        [Given(@"I see the Homepage Fully Loaded")]
        public void GivenISeeTheHomepageFullyLoaded()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["SwordActive_Risk_Homepage"]);
            currentdriver = Browser.Current;
            if (currentdriver.FindElement(By.Id("logo")).Displayed == true)
                Console.WriteLine("Page Loaded Fully");
            else
                Console.WriteLine("Page Failed to Load");
        }

         [When(@"I type search keyword as")]
        public void WhenITypeSearchKeywordAs(Table table)
        {
            dynamic tableDetail = table.CreateDynamicInstance();
            currentdriver.FindElement(By.Name("s")).SendKeys(tableDetail.keyword);

            
        }

        [Then(@"I should  see the result for Keyword")]
        public void ThenIShouldSeeTheResultForKeyword(Table table)
        {
            dynamic tableDetail = table.CreateDynamicInstance();
            string key = tableDetail.Keyword;
            if (currentdriver.FindElement(By.Id("Key")).Displayed == true)
                Console.WriteLine("Control exist");
            else
                Console.WriteLine("Control doesnt exist");
            
        }
    }
}
