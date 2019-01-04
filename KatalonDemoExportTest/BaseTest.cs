using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Drawing.Imaging;

namespace KatalonDemoExportTest
{
    [TestClass]
    public class BaseTest
    {
        private IWebDriver driver;
        private HomePage homePage;

        public BaseTest()
        {
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
            homePage = new HomePage(this.driver);
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public HomePage MyHomePage
        {
            get
            {
                return homePage;
            }
        }

        [TestInitialize]
        public void TestInitialize()
        {
            driver.Manage().Window.Maximize();
        }
        
        [TestCleanup]
        public void TestMethodCleanUp()
        {
            try
            {
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public void MakeScreenshot()
        {
            Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
            string Runname = "my_screenshot" + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string screenshotfilename = Runname + ".jpg";
            ss.SaveAsFile(screenshotfilename);
        }
    }
}
