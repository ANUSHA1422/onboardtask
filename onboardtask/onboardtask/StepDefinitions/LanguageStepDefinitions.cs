using System;
using NUnit.Framework;
using onboardtask.Pages;
using TechTalk.SpecFlow;

namespace onboardtask.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions
    {
        [When(@"I added language in the profile page")]
        public void WhenIAddedLanguageInTheProfilePage()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.AddLanguage();
        }

        [Then(@"The language should be added successfully")]
        public void ThenTheLanguageShouldBeAddedSuccessfully()
        {
            LanguagePage languagePageObj = new LanguagePage();
            string newlanguage = languagePageObj.GetLanguage();
            Assert.That(newlanguage == "english", "actual language and expected language do not  match");
        }

        [When(@"I edit'([^']*)'in the existing langauge record")]
        public void WhenIEditinTheExistingLangaugeRecord(string language)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.EditLanguage();
        }
        [Then(@"The record should have the edited '([^']*)' \.")]
        public void ThenTheRecordShouldHaveTheEdited_(string language)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string newEditedlanguage = languagePageObj.GetEditedLanguage(); 
            Assert.That(newEditedlanguage == "telugu", "actual language and expected language do not  match");
        }

        [When(@"I delete language from an exisiting langauge record")]
        public void WhenIDeleteLanguageFromAnExisitingLangaugeRecord()
        {
             LanguagePage languagePageObj = new LanguagePage();
             languagePageObj.DeleteLanguage();
        }

        [Then(@"The language should be deleted successfully")]
        public void ThenTheLanguageShouldBeDeletedSuccessfully()
        {
            LanguagePage languagePageObj = new LanguagePage();
            string deletedlangauge = languagePageObj.GetDeletedLanguage();
            Assert.That(deletedlangauge != "Telugu", "actual and expected langauge match");
        }
    }
}
