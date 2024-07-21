using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowMarsApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowMarsApplication.Pages
{
    
    public class WebelementContainer : CommonDriver
    {
      
        public IWebElement languageLocator => driver.FindElement(By.XPath("//div[text()='Add New']"));
      //  public IWebElement userNameLocator => driver.FindElement(By.XPath("//span[contains(@class ,'item')]"));
        public IWebElement selectProfileLocator => driver.FindElement(By.XPath("//a[contains(text(),'Go to Profile')]"));
        public IWebElement addLanguageLocator => driver.FindElement(By.Name("name"));
        public IWebElement selectLanguageLocator => driver.FindElement(By.Name("level"));
        public IWebElement addButtonLocator => driver.FindElement(By.XPath("//*[@value='Add']"));
        public IWebElement editButtonLocator => driver.FindElement(By.XPath("//i[contains(@class,'outline write icon')]"));
        //public IWebElement editButtonLocator => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[1]/i[1]"));
        public IWebElement editLanguageLocator => driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));
        public IWebElement updateLanguageLocator => driver.FindElement(By.XPath("//input[@value='Update']"));
       
    }
}
