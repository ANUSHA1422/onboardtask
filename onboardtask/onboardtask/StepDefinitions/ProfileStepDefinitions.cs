using System;
using onboardtask.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using onboardtask.Utilities;
using NUnit.Framework;

namespace onboardtask.StepDefinitions
{
    [Binding]
    public class ProfileStepDefinitions: CommonDriver
    {
        [Given(@"I logged into the local host portal successfully")]
        public void GivenILoggedIntoTheLocalHostPortalSuccessfully()
        {
            IWebDriver driver = new ChromeDriver();

            SignInPage signinPageObj = new SignInPage();
            signinPageObj.SignInSteps(driver);

        }

        [When(@"I added description in the profile page")]
        public void WhenIAddedDescriptionInTheProfilePage()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddDescription(driver);
        }

        [Then(@"The description should be added successfully")]
        public void ThenTheDescriptionShouldBeAddedSuccessfully()
        {
            ProfilePage profilePageObj = new ProfilePage();
            string newDescription = profilePageObj.GetDescription(driver);
            Assert.That(newDescription == "HELLO", "actual description and expected description do Not match");
        }



        [When(@"I added language in the profile page")]
        public void WhenIAddedLanguageInTheProfilePage()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddLanguage(driver);

        }
        [Then(@"The language should be added successfully")]
        public void ThenTheLanguageShouldBeAddedSuccessfully()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            string newLanguage = ProfilePageObj.GetLanguage(driver);
            Assert.That(newLanguage == "telugu", "actual language and expected language do Not match");
        }




        [When(@"I added skill in the profile page")]
        public void WhenIAddedSkillInTheProfilePage()
        {
            ProfilePage profilepageobj = new ProfilePage();
            profilepageobj.AddSkill(driver);
        }
        [Then(@"The skill should be added successfully")]
        public void ThenTheSkillShouldBeAddedSuccessfully()
        {

            ProfilePage ProfilePageObj = new ProfilePage();
            string newSkill = ProfilePageObj.GetSkill(driver);
            Assert.That(newSkill == "PAINT", "actual skill and expected skill do Not match");
        }




    }


}

