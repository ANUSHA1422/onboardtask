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
    public class LanguagePage:CommonDriver
    {
        public void AddLanguage()
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@data-tab='first']", 9);
            IWebElement Language = driver.FindElement(By.XPath("//a[@data-tab='first']"));
            Language.Click();
            IWebElement AddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 2);

            IWebElement AddLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            AddLanguage.Click();
            AddLanguage.Clear();
            AddLanguage.SendKeys("english");

            IWebElement ChooseLevel = driver.FindElement(By.XPath("//select[@name='level']"));
            ChooseLevel.Click();
            var languageLevel = driver.FindElement(By.Name("level"));
            var selectElement = new SelectElement(languageLevel);
            selectElement.SelectByValue("Fluent");

           

            IWebElement AddButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddButton.Click();
           
            IWebElement newlanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(newlanguage.Text == "english", "actual language and expected language do not  match");
        }

        public string GetLanguage()
        {
            IWebElement newlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]//div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newlanguage.Text;
        }

        public void EditLanguage()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]", 9);
            IWebElement UpdateLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
            UpdateLanguage.Click();
            IWebElement newlanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            newlanguage.Clear();
           
            newlanguage.SendKeys("telugu");


            IWebElement newEditedlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(newEditedlanguage.Text == "telugu", "actual language and expected language do not  match");

        }
        public void EditLangaugeLevel()
        {
            
            var languageLevel = driver.FindElement(By.Name("level"));
            var selectElement = new SelectElement(languageLevel);
            selectElement.SelectByValue("Native/Bilingual");

            IWebElement UpdateButton = driver.FindElement(By.XPath("//input[@type='button']"));
            UpdateButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//input[@type='button']", 2);

            IWebElement newEditedlanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(newEditedlanguageLevel.Text == "Native/Bilingual", "actual level and expected level do NotFiniteNumberException match");

        }
        public string GetEditedLanguage()
        {
            IWebElement newlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newlanguage.Text;
        }
        public string GetEditedLangauagelevel()
        {
            IWebElement newEditedlanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return newEditedlanguageLevel.Text;
        }
        public void DeleteLanguage()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 3);                    
            IWebElement editedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            editedLanguage.Click();

            IWebElement DeleteLanguage = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            DeleteLanguage.Click();
            IWebElement deletedlangauge = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]"));
            Assert.That(deletedlangauge.Text != "Telugu", "actual and expected langauge match");
               
        }
        public string GetDeletedLanguage()
        {
            IWebElement newlanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            return newlanguage.Text;
        }


    }
}
