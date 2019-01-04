using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KatalonDemoExportTest
{
    [TestClass]
    public class LoginTests : BaseTest
    {
        [TestMethod]
        public void TestLoginWithInvalidMail()
        {
            // Arrange
            MyHomePage.NavigateToPageUrl();
            string[] invalidEmails = 
            {
                "plainaddress",
                "#@%^%#$@#$@#.com",
                "email.domain.com",
                "email@domain@domain.com"
            };

            // Act
            foreach (var email in invalidEmails)
            {
                MyHomePage.EnterEmailAddress(email);
                MyHomePage.CleanDropDown();

                // This is bad practice and is for demo purposes only.
                // Consider using Selenium Wait
                System.Threading.Thread.Sleep(1000);

                MyHomePage.Login();

                // Assert
                try
                {
                    Assert.AreEqual(
                            "Please enter a valid e-mail address", MyHomePage.ErrorMessage.Text,
                            "This error messege shoud appear when invalid mail is entered");
                }
                catch(Exception e)
                {
                    MakeScreenshot();
                    Assert.Fail(e.Message, "This error messege shoud appear when invalid mail is entered");
                }
            }
        }
    }
}
