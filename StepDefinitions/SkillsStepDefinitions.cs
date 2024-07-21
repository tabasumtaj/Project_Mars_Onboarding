using SpecFlowMarsApplication.Pages;
using SpecFlowMarsApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowMarsApplication.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions : CommonDriver
    {

       // private readonly LoginPage loginObject;
       
        private readonly Skills skillsObject;

        public SkillsStepDefinitions()
        {
            skillsObject = new Skills();
        }
        //----Skills step definitions--------------------------//
        [When(@"User Navigate to Profile clicks on skills")]
        public void WhenUserNavigateToProfileClicksOnSkills()
        {
            skillsObject.skill();
        }

        [Then(@"Add new button is click to add skills and skilllevel")]
        public void ThenAddNewButtonIsClickToAddSkillsAndSkilllevel()
        {
            skillsObject.Addskill();
        }

        [Then(@"User can enter skills list in '([^']*)' and '([^']*)'")]
        public void ThenUserCanEnterSkillsListInAnd(String skills, String skillslevel)
        {
            skillsObject.AddskillLst(skills, skillslevel);
        }

        [When(@"User Navigate to Profile clicks on skills to update")]
        public void WhenUserNavigateToProfileClicksOnSkillsToUpdate()
        {
            skillsObject.skill();
            
        }

        [When(@"User clicks on edit button to change the '([^']*)' and '([^']*)'")]
        public void WhenUserClicksOnEditButtonToChangeTheAnd(String skills, String skilllevel)
        {
            skillsObject.editButtonClick(skills, skilllevel);
            //throw new PendingStepException();
        }

        [Then(@"User will click the update button to add '([^']*)' with '([^']*)'")]
        public void ThenUserWillClickTheUpdateButtonToAddWith(String skills, String newlevel)
        {
            skillsObject.UpdateSkills(skills, newlevel);
        }

    }
}