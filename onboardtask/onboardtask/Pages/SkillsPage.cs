using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using onboardtask.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace onboardtask.Pages
{
    public class SkillsPage:CommonDriver
    {


        public void AddSkill()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]//div[3]/form/div[1]/a[2]", 12);
            IWebElement Skill = driver.FindElement(By.XPath("//div/section[2]//div[3]/form/div[1]/a[2]"));
            Skill.Click();

            IWebElement AddNewSkill = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            AddNewSkill.Click();

            IWebElement AddSkill = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            AddSkill.Clear();
            AddSkill.SendKeys("SING");
            Thread.Sleep(2000);

            IWebElement Level = driver.FindElement(By.XPath("//select[@name='level']"));
            Level.Click();
            IWebElement skillLevel = driver.FindElement(By.Name("level"));
            var selectElement = new SelectElement(skillLevel);
            selectElement.SelectByValue("Beginner");

            //IWebElement LevelBeginner = driver.FindElement(By.XPath("//option[@value='Beginner']"));
            //LevelBeginner.Click();

            IWebElement ADDBUTTON = driver.FindElement(By.XPath("//input[@value='Add']"));
            ADDBUTTON.Click();
            Thread.Sleep(2000);

            IWebElement newSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(newSkill.Text == "SING", "actual skill and expected skill do not match");
        }
        public string Getskill()
        {
            IWebElement newskill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newskill.Text;
        }
        public void EditSkill()
        {
            //EDIT SKILL
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]//div[3]/form/div[1]/a[2]", 7);
            IWebElement Skill = driver.FindElement(By.XPath("//div/section[2]//div[3]/form/div[1]/a[2]"));
            Skill.Click();

            IWebElement EditSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            EditSkill.Click();
            IWebElement ADDnewSKILL = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            ADDnewSKILL.Clear();
            ADDnewSKILL.SendKeys("PAINT");
            //Thread.Sleep(2000);

            //IWebElement chooselevel = driver.FindElement(By.XPath("//select[@name='level']"));
            //chooselevel.Click();
            //IWebElement skillLevel = driver.FindElement(By.Name("level"));
            //IWebElement selectElement = new SelectElement(skillLevel);
            //selectElement.SelectByValue("Expert");

            //IWebElement NEWLEVEL = driver.FindElement(By.XPath("//option[@value='Expert']"));
            //NEWLEVEL.Click();
            //Thread.Sleep(2000);
            //IWebElement UPDATEBUTTON = driver.FindElement(By.XPath("//input[@value='Update']"));
            //UPDATEBUTTON.Click();
            //Thread.Sleep(2000);

            IWebElement NewEditedSkill = driver.FindElement(By.XPath("//div/section[2]//div[3]/form/div[3]//div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(NewEditedSkill.Text != "PAINT", "actual skill and expected skill do not match");
        }
        public void EditSkillLevel()
        {
            //Thread.Sleep(1000);
            //IWebElement chooselevel = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]//div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            //chooselevel.Click();
            //Thread.Sleep(2000);
            var skillLevel = driver.FindElement(By.Name("level"));
            var selectElement = new SelectElement(skillLevel);
            selectElement.SelectByValue("Expert");

            //IWebElement NEWLEVEL = driver.FindElement(By.XPath("//option[@value='Expert']"));
            //NEWLEVEL.Click();
           
            IWebElement UPDATEBUTTON = driver.FindElement(By.XPath("//input[@value='Update']"));
            UPDATEBUTTON.Click();
            //Thread.Sleep(2000);

            //IWebElement NewEditedSkillLevel = driver.FindElement(By.XPath("//div/section[2]//div[3]/form/div[3]//div[2]/div/table/tbody/tr/td[2]"));
            //Assert.That(NewEditedSkillLevel.Text == "Expert", "actual level and expected level do not match");
        }
        public string GetEditedskill()
        {
            IWebElement NewEditedskill = driver.FindElement(By.XPath("//div/section[2]//div[3]/form/div[3]//div[2]/div/table/tbody/tr/td[1]"));
            return NewEditedskill.Text;
        }
        public string GetEditedSkillLevel()
        {
            Thread.Sleep(1000);
            IWebElement NewEditedSkillLevel = driver.FindElement(By.XPath("//tbody/tr/td[2]"));
            return NewEditedSkillLevel.Text;
        }
        public void DeletedSkill()
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]//div[3]/form/div[3]//div[2]/div/table/tbody/tr/td[1]", 12);
            //IWebElement Skill = driver.FindElement(By.XPath("//div/section[2]//div[3]/form/div[1]/a[2]"));
            //Skill.Click();
            IWebElement editedSkill = driver.FindElement(By.XPath("//div/section[2]//div[3]/form/div[3]//div[2]/div/table/tbody/tr/td[1]"));
            editedSkill.Click();

            IWebElement DeleteSkill = driver.FindElement(By.XPath("//i[@class='remove icon']"));//div/section[2]//div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]
            DeleteSkill.Click();

            IWebElement DeletedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]"));
            Assert.That(DeletedSkill.Text != "null", "actual and expected skill do not match");
        }
        public string GetDeletedskill()
        {
            IWebElement DeletedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]"));
            return DeletedSkill.Text;
        }
    }
}
