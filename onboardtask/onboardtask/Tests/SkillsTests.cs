using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using onboardtask.Pages;
using onboardtask.Utilities;

namespace onboardtask.Tests
{
    public class SkillsTests : CommonDriver
    {
        [Test, Order(1)]
        public void AddSkillTest()
        {
            SkillsPage skillPageObj = new SkillsPage();
            skillPageObj.AddSkill();
        }
        [Test, Order(2)]
        public void EditSkillTest()
        {
            SkillsPage skillPageObj = new SkillsPage();
            skillPageObj.EditSkill();
        }

        [Test,Order(3)]
        public void EditSkillLevelTest()
        {
            SkillsPage skillPageObj = new SkillsPage();
            skillPageObj.EditSkillLevel();

        }
        [Test, Order(4)]
        public void DeleteLangaugeTest()
        {
            SkillsPage skillPageObj = new SkillsPage();
            skillPageObj.DeletedSkill();
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
