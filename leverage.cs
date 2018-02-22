using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace TOOLQA
{
   class leverage
    {
        IWebDriver driver = new ChromeDriver();
                //Go to the Homepage
        [SetUp]
        public void Intialize()
        {
           
            driver.Navigate().GoToUrl(" http://www.sword-activerisk.com");
            Console.WriteLine("Opened URL");
        }

        //Get the page Elements
        [Test]
        public void Executetest()
        {

            IWebElement element = driver.FindElement(By.Name("s"));

            IWebElement Searchelement = driver.FindElement(By.Id("searchsubmit"));
            element.SendKeys("Leverage");
            Searchelement.Click();
            Console.WriteLine("verify the link Clicked");


            IWebElement body = driver.FindElement(By.Id("page-content"));
            string actualvalue = driver.FindElement(By.Id("page-content")).Text;
            Assert.IsTrue(actualvalue.Contains("Leverage"), actualvalue + " doesn't contains Leverage'");
        }
        //Close the Browser

        [TearDown]
        public void Cleanup()
        {

            driver.Close();
            Console.WriteLine("Closed the browser");
        }



        }
    }






