using OpenQA.Selenium;
using SpecFlowMarsApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
namespace SpecFlowMarsApplication.Pages
{
    public class Skills : CommonDriver
    {

        IWebElement skillsLocator => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        IWebElement addnewskillLocator => driver.FindElement(By.XPath("//div[contains(@class,'ui teal button')]"));
        IWebElement addskillsLocator => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        IWebElement selectskillleveleLocator => driver.FindElement(By.Name("level"));
        IWebElement addButtonLocator => driver.FindElement(By.XPath("//*[@value='Add']"));
        IWebElement editButtonLocator => driver.FindElement(By.XPath("//html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]\r\n"));
        IWebElement editSkillsLocator => driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));
        IWebElement updateSkillsLocator => driver.FindElement(By.XPath("//html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
        IWebElement skillsContainer => driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody"));
       
public Skills()
        {

        }
        public void skill()
        {
            skillsLocator.Click();
        }
        public void Addskill()
        {

            addnewskillLocator.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(addnewskillLocator));

            // addnewskillLocator.Clear();
        }

        public void AddskillLst(String skills, String skillslevel)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            addskillsLocator.SendKeys(skills);
            wait.Until(ExpectedConditions.ElementToBeClickable(addskillsLocator));
            addskillsLocator.Clear();
            selectskillleveleLocator.SendKeys(skillslevel);
            wait.Until(ExpectedConditions.ElementToBeClickable(selectskillleveleLocator));
            addButtonLocator.Click();
            Thread.Sleep(5000);
        }
        public void editButtonClick(String skills, String skilllevel)
        {

            editButtonLocator.Click();
        }
     
        public void UpdateSkills(String skills, String newlevel)
        {
            IWebElement existingSkillElement = null;
            try
            {
               

                existingSkillElement = skillsContainer.FindElement(By.XPath("//html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[5]/tr[1]/td[1]"));
             
            }
            catch (NoSuchElementException)
            {
                 Console.WriteLine($"Skill '{skills}' does not exist. Proceeding to add new skill.");
            }
            try
            {
                if (existingSkillElement != null)
                {
                   
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    wait.Until(ExpectedConditions.ElementToBeClickable(editSkillsLocator));
                    editSkillsLocator.Clear();
                    editSkillsLocator.SendKeys(skills);
                    wait.Until(ExpectedConditions.ElementToBeClickable(editSkillsLocator));
                    selectskillleveleLocator.SendKeys(newlevel);
                    wait.Until(ExpectedConditions.ElementToBeClickable(updateSkillsLocator));
                    updateSkillsLocator.Click();
                    Thread.Sleep(7000);
                }
                else
                {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    wait.Until(ExpectedConditions.ElementToBeClickable(editSkillsLocator));
                    editSkillsLocator.Clear();
                    editSkillsLocator.SendKeys(skills);

                    wait.Until(ExpectedConditions.ElementToBeClickable(selectskillleveleLocator));
                    selectskillleveleLocator.SendKeys(newlevel);
                }
            }
            catch (NoSuchElementException ex)
            {
                // Handle NoSuchElementException

                Console.WriteLine($"Assertion Error for '{editSkillsLocator}': {ex.Message}");
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);

            }

        }
    }
}
