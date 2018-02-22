using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TOOLQA
{
    class RiskManagement
    {

       static void Main(string[] args)
        {
            //Intialise the FirefoxDriver

            IWebDriver driver = new FirefoxDriver();

            //Go to the Homepage

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(" http://www.sword-activerisk.com");

            //Get the page Elements

            IWebElement element = driver.FindElement(By.Name("s"));
            IWebElement Searchelement = driver.FindElement(By.Id("searchsubmit"));

            //Enter the text 

            element.SendKeys("Risk Management");
            Searchelement.Click();

            IWebElement body = driver.FindElement(By.Id("page-content"));

            //verify the Risk Management text is present or not
            string actualvalue = driver.FindElement(By.Id("page-content")).Text;
            Assert.IsTrue(actualvalue.Contains("Management"), actualvalue + " doesn't contains Management'");

            //Close the Browser


            driver.Close();

            


        }
    }


}
