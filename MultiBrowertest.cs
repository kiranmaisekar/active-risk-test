using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace MultipleBrowserTest
{
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(InternetExplorerDriver))]
    public class BlogTest<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private IWebDriver driver;

      
        public void Visit_ActiveDiskHomepage()
        {
            driver = new TWebDriver();

            // Navigate to homepage 
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.sword-activerisk.com/");
        }

       public void FixtureTearDown()
        {
            if (driver != null)
                driver.Close();
        }
    }
}
