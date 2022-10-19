using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using onboardtask.Utilities;
using OpenQA.Selenium;

namespace onboardtask.Pages
{
    public class ProfilePage
    {
        public void AddDescription(IWebDriver driver)
        {
           
            
            try
            {


                IWebElement WriteDecription = driver.FindElement(By.XPath("//i[@class='outline write icon']"));
                WriteDecription.Click();
                Thread.Sleep(1000);
                IWebElement Description = driver.FindElement(By.XPath("//textarea[@name='value']"));
                Description.Click();
                Description.Clear();
                Description.SendKeys("HELLO");
                Thread.Sleep(3000);

                IWebElement SaveButton = driver.FindElement(By.XPath("//button[@type='button']"));
                SaveButton.Click();
                //IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div"));
                //Assert.That(newDescription.Text != "HELLO", "actual description and expected description do not  match");

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }
        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div"));
            return newDescription.Text;
        }






        public void AddLanguage(IWebDriver driver)
        {
            //language
            try
            {


                IWebElement Language = driver.FindElement(By.XPath("//a[@data-tab='first']"));
                Language.Click();
                IWebElement AddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
                AddNew.Click();
                Thread.Sleep(2000);

                IWebElement AddLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
                AddLanguage.Click();
                AddLanguage.Clear();
                AddLanguage.SendKeys("english");

                IWebElement ChooseLevel = driver.FindElement(By.XPath("//select[@name='level']"));
                IWebElement LevelFluent = driver.FindElement(By.XPath("//option[@value='Fluent']"));
                LevelFluent.Click();
                Thread.Sleep(2000);

                IWebElement AddButton = driver.FindElement(By.XPath("//input[@value='Add']"));
                AddButton.Click();

                //edit language

                IWebElement UpdateLanguage = driver.FindElement(By.XPath("//i[@class='outline write icon']"));
                UpdateLanguage.Click();
                IWebElement newlanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
                //addlanaguage.Clear();
                //Thread.Sleep(2000);
                newlanguage.SendKeys("telugu");

                IWebElement ADDlevel = driver.FindElement(By.XPath("//option[@value='Fluent']"));
                ADDlevel.Click();
                IWebElement LevelNative = driver.FindElement(By.XPath("//option[@value='Native/Bilingual']"));
                LevelNative.Click();
                Thread.Sleep(2000);
                IWebElement UpdateButton = driver.FindElement(By.XPath("//input[@type='button']"));
                UpdateButton.Click();
                Thread.Sleep(2000);


                //delete
                IWebElement DeleteLanguage = driver.FindElement(By.XPath("//i[@class='remove icon']"));
                DeleteLanguage.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        public string GetLanguage(IWebDriver driver)
        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            return newLanguage.Text;
        }




        public void AddSkill(IWebDriver driver)
        {

            //skill
            try
            {
                Thread.Sleep(1000);
                IWebElement Skill = driver.FindElement(By.XPath("//a[@data-tab='second']"));
                Skill.Click();

                IWebElement AddNewSkill = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
                AddNewSkill.Click();

                IWebElement AddSkill = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
                AddSkill.Clear();
                AddSkill.SendKeys("sing");
                Thread.Sleep(2000);

                IWebElement Level = driver.FindElement(By.XPath("//select[@name='level']"));
                //Level.Click();

                IWebElement LevelBeginner = driver.FindElement(By.XPath("//option[@value='Beginner']"));
                LevelBeginner.Click();
                IWebElement ADDBUTTON = driver.FindElement(By.XPath("//input[@value='Add']"));
                ADDBUTTON.Click();
                Thread.Sleep(2000);

                //EDIT SKILL
                IWebElement EditSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
                EditSkill.Click();
                IWebElement ADDnewSKILL = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
                ADDnewSKILL.Clear();
                ADDnewSKILL.SendKeys("PAINT");
                Thread.Sleep(2000);

                IWebElement chooselevel = driver.FindElement(By.XPath("//select[@name='level']"));
                chooselevel.Click();
                IWebElement NEWLEVEL = driver.FindElement(By.XPath("//option[@value='Expert']"));
                NEWLEVEL.Click();
                Thread.Sleep(2000);
                IWebElement UPDATEBUTTON = driver.FindElement(By.XPath("//input[@value='Update']"));
                UPDATEBUTTON.Click();
                Thread.Sleep(2000);

                //DELETE
                IWebElement DELETESKILL = driver.FindElement(By.XPath("//i[@class='remove icon']"));
                //DELETESKILL.Click();


            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }


        }
        public string GetSkill(IWebDriver driver)
        {
            IWebElement newSkill = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            return newSkill.Text;
        }

    }
}
