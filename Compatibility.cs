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
    class Compatibility
    {


        public static void Main1()
        {
            IWebDriver driver = new FirefoxDriver();
            IWebDriver currentdriver = null;
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(" http://www.sword-activerisk.com");

            //Get the page Elements

            IWebElement element = driver.FindElement(By.Name("s"));
            element.SendKeys("Compatibility");

            IWebElement Searchelement = driver.FindElement(By.Id("searchsubmit"));

            Searchelement.Click();

            

            //verify the leverage text is present or not

            string actualvalue = driver.FindElement(By.Id("page-content")).Text;
            if (currentdriver.FindElement(By.Id(actualvalue)).Displayed == true)
                Console.WriteLine("compatibility text found");
            else
                Console.WriteLine("sorry no reuslts found");
            driver.FindElement(By.LinkText("Return to Previous Screen")).Click();
               

            //Close the Browser


            driver.Close();


        }
    }
}




       
            
            
        