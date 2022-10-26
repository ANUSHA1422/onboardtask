using System;
using NUnit.Framework;
using onboardtask.Pages;
using TechTalk.SpecFlow;

namespace onboardtask.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions
    {
        [When(@"I added skill in the profile page")]
        public void WhenIAddedSkillInTheProfilePage()
        {

            SkillsPage skillPageObj = new SkillsPage();
            skillPageObj.AddSkill();
        }

        [Then(@"The skill should be added successfully")]
        public void ThenTheSkillShouldBeAddedSuccessfully()
        {
            SkillsPage skillPageObj = new SkillsPage();
            string newSkill =skillPageObj.Getskill();
            Assert.That(newSkill == "SING", "actual skill and expected skill do not match");
        }
        [When(@"I edit'([^']*)','([^']*)',in the existing skill record")]
        public void WhenIEditInTheExistingSkillRecord(string PAINT, string Expert)
        {
            SkillsPage skillPageObj = new SkillsPage();
            skillPageObj.EditSkill();
            skillPageObj.EditSkillLevel();
        }
        [Then(@"The record should have the edited '([^']*)' ,'([^']*)' \.")]
        public void ThenTheRecordShouldHaveTheEdited_(string PAINT, string Expert)
        {
            SkillsPage skillPageObj = new SkillsPage();
            string NewEditedSkill = skillPageObj.GetEditedskill();
            string NewEditedSkillLevel = skillPageObj.GetEditedSkillLevel();
            Assert.That(NewEditedSkill != "PAINT", "actual skill and expected skill do not match");
            Assert.That(NewEditedSkillLevel == "Expert", "actual level and expected level do not match");
        }

        [When(@"I delete skill from an exisiting skill record")]
        public void WhenIDeleteSkillFromAnExisitingSkillRecord()
        {
            SkillsPage skillPageObj = new SkillsPage();
            skillPageObj.DeletedSkill();
        }


        [Then(@"The skill should be deleted successfully")]
        public void ThenTheSkillShouldBeDeletedSuccessfully()
        {
            SkillsPage skillPageObj = new SkillsPage();
            string DeletedSkill = skillPageObj.GetDeletedskill();
            Assert.That(DeletedSkill != "null", "actual and expected skill do not match");
        }
    }
}
