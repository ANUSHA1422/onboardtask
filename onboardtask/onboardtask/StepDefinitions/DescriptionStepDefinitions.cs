using System;
using NUnit.Framework;
using onboardtask.Pages;
using onboardtask.Utilities;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace onboardtask.StepDefinitions
{
    [Binding]
    public class DescriptionStepDefinitions:CommonDriver
    {
        [Given(@"I logged into the local host portal successfully")]
        public void GivenILoggedIntoTheLocalHostPortalSuccessfully()
        {
            driver = new ChromeDriver();

            SignInPage signinPageObj = new SignInPage();
            signinPageObj.SignInSteps(driver);
        }

        [When(@"I added description in the profile page")]
        public void WhenIAddedDescriptionInTheProfilePage()
        {
            DescriptionPage descriptionPageObj = new DescriptionPage();
            descriptionPageObj.AddDescription();
        }

        [Then(@"The description should be added successfully")]
        public void ThenTheDescriptionShouldBeAddedSuccessfully()
        {
            DescriptionPage descriptionPageObj = new DescriptionPage();
            string newDescription = descriptionPageObj.GetDescription();
            Assert.That(newDescription != "HELLO", "actual description and expected description do not  match");

        }
    }
}
