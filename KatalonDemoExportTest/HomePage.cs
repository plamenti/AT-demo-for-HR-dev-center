using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace KatalonDemoExportTest
{
    public class HomePage
    {
        private IWebDriver driver;
        string url = "https://www.newchic.com/login.html";

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public IWebElement LoginNameTextField
        {
            get
            {
                return Driver.FindElement(By.Id("log_email"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return Driver.FindElement(By.Id("signbtn"));
            }
        }

        public IWebElement ErrorMessage
        {
            get
            {
                return Driver.FindElement(By.Id("emailerr"));
            }
        }

        public IWebElement LoginLabel
        {
            get
            {
                return Driver.FindElement(By.XPath("//h5[text()='Log in']"));
            }
        }

        public void NavigateToPageUrl()
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void EnterEmailAddress(string email)
        {
            LoginNameTextField.Click();
            LoginNameTextField.Clear();
            LoginNameTextField.SendKeys(email);
        }

        public void Login()
        {
            LoginButton.Click();
        }

        public void CleanDropDown()
        {
            LoginLabel.Click();
        }
    }
}
