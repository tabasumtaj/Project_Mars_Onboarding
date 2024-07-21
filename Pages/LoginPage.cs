using SpecFlowMarsApplication.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowMarsApplication.Pages
{
    public class LoginPage : CommonDriver
    {
        //private WebelementContainer elementContainer;
        public IWebElement userNameLocator => driver.FindElement(By.XPath("//span[contains(@class ,'item')]"));

        //public LoginPage()
        //{
        //    this.elementContainer = new WebelementContainer();
        //}

        // Methods with web elements in the login page to perform login action
        public void ToSignup()
        {
            Thread.Sleep(3000);
            userNameLocator.Click();
        }
    }
}

