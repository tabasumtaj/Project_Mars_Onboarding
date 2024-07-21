using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowMarsApplication.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlowMarsApplication.Utilities;
using System.Reflection.Emit;
using OpenQA.Selenium.Support.UI;


namespace SpecFlowMarsApplication.StepDefinitions
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
  
        private readonly LoginPage loginObject;
        private readonly Languages languageObject;
       
        public ProfileStepDefinitions(){
           
            loginObject = new LoginPage();
            languageObject = new Languages();
        }

       
        
        [Given(@"User enters the valid credentials to login MarsApplication")]
        public void GivenUserEntersTheValidCredentialsToLoginMarsApplication()
        {
            loginObject.ToSignup();
           
        }

        [When(@"User Navigate to Profile page and clicks Add new button to add Language and level")]
        public void WhenUserNavigateToProfilePageAndClicksAddNewButtonToAddLanguageAndLevel()
        {
            languageObject.Language();
                
                }

        [Then(@"User enters maximum four languages '([^']*)' and '([^']*)'")]
        public void ThenUserEntersMaximumFourLanguagesAnd(String language, String level)
        {
            languageObject.AddLanguage(language, level);
        }

        [When(@"User Navigate to Profile page to show Language and level")]
        public void WhenUserNavigateToProfilePageToShowLanguageAndLevel()
        {
          
        }

        [When(@"User clicks on edit to change the '([^']*)' and '([^']*)'")]
        public void WhenUserClicksOnEditToChangeTheAnd(String language, String level)
        {
            languageObject.editButtonClick(language, level);
        }
        [Then(@"User will click the update button to update '([^']*)' and '([^']*)'")]
        public void ThenUserWillClickTheUpdateButtonToUpdateAnd(String language, String newlevel)
        {
            languageObject.UpdateLanguage(language, newlevel);
        }

        [When(@"User Navigate to Profile page and shows the language and level")]
        public void WhenUserNavigateToProfilePageAndShowsTheLanguageAndLevel()
        {
         
        }
       
        [When(@"User clicks delete to remove the language and pop up message is shown\.")]
        public void WhenUserClicksDeleteToRemoveTheLanguageAndPopUpMessageIsShown_()
        {
            languageObject.RemoveLanguage();
        }

    }
}
