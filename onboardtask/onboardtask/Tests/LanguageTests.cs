using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using onboardtask.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using onboardtask.Utilities;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace onboardtask.Tests
{
    public class LanguageTests:CommonDriver
    {
        IWebDriver driver = new ChromeDriver();

       

        [Test, Order(1)]
        public void AddLanguageTest()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.AddLanguage();
        }
        [Test, Order(2)]
        public void EditLanguageTest()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.EditLanguage();
        }

        [Test, Order(3)]
        public void EditLanguageLevelTest()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.EditLangaugeLevel();

        }
        [Test, Order(4)]
        public void DeleteLangaugeTest()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.DeleteLanguage();
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

       

    }
}
