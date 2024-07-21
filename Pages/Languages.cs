using AngleSharp.Dom;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using SpecFlowMarsApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Reflection.Emit;

namespace SpecFlowMarsApplication.Pages
{
    public class Languages : CommonDriver
    {
         IWebElement languageLocator => driver.FindElement(By.XPath("//div[text()='Add New']"));
         IWebElement selectProfileLocator => driver.FindElement(By.XPath("//a[contains(text(),'Go to Profile')]"));
         IWebElement addLanguageLocator => driver.FindElement(By.Name("name"));
         IWebElement selectLanguageLocator => driver.FindElement(By.Name("level"));
         IWebElement addButtonLocator => driver.FindElement(By.XPath("//*[@value='Add']"));
         IWebElement editButtonLocator => driver.FindElement(By.XPath("//html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
         IWebElement editLanguageLocator => driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));
         IWebElement updateLanguageLocator => driver.FindElement(By.XPath("//input[contains(@class,'ui teal button')]"));
         IWebElement deleteButton => driver.FindElement(By.XPath("//i[contains(@class,'remove icon')]"));
        public Languages()
        {

        }
         public void Language()
        {
           languageLocator.Click();
         
        }          
        public void AddLanguage(String language,String level)
        {
       addLanguageLocator.SendKeys(language);
            addLanguageLocator.Clear();
            selectLanguageLocator.SendKeys(level);
       addButtonLocator.Click();
            Thread.Sleep(3000);
        }

        public void editButtonClick(String language, String level)
        {
           
            editButtonLocator.Click();
        }
        public void UpdateLanguage(String language, String newlevel) {
            try
            {
                //editButtonLocator.Click();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(editLanguageLocator));
                editLanguageLocator.Clear();
                editLanguageLocator.SendKeys(language);
                wait.Until(ExpectedConditions.ElementToBeClickable(selectLanguageLocator));
                 selectLanguageLocator.SendKeys(newlevel);
                //wait.Until(ExpectedConditions.ElementToBeClickable(selectLanguageLocator));
                wait.Until(ExpectedConditions.ElementToBeClickable(updateLanguageLocator));
                updateLanguageLocator.Click();
                Thread.Sleep(7000);
                
            }
            catch (NoSuchElementException ex)
            {
                // Handle NoSuchElementException

                Console.WriteLine($"Assertion Error for '{editLanguageLocator}': {ex.Message}");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("An error occurred: " + ex.Message);
                
            }
       
    }
        public void RemoveLanguage()
        {
            try
            {       
                
                deleteButton.Click();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            }
            catch
            {

            }
            
           
        }
    }
    }

