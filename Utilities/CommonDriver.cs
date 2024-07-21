using OpenQA.Selenium.Chrome;
using SpecFlowMarsApplication.Pages;

using OpenQA.Selenium;
using NUnit.Framework;

namespace SpecFlowMarsApplication.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // Launching the url
            driver.Navigate().GoToUrl("http://localhost:5000/");
            IWebElement signUpButton = driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
            signUpButton.Click();
            try
            {
                IWebElement emailAddress = driver.FindElement(By.Name("email"));
                emailAddress.SendKeys("tabaj33@gmail.com");
            }
            catch (Exception e)
            {
                Assert.Fail("email id is valid ", e.Message);
            }
            IWebElement passWord = driver.FindElement(By.Name("password"));
            passWord.SendKeys("MarsTest@24");
            IWebElement loginButton = driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
            loginButton.Click();
        }
        public void Close()
        {
            driver.Close();
        }
    }

}