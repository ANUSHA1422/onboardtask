using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using onboardtask.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace onboardtask.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        [SetUp, OneTimeSetUp]
        public void SignInActions()
        {
            IWebDriver driver = new ChromeDriver();

            SignInPage signinPageObj = new SignInPage();
            signinPageObj.SignInSteps(driver);

            LanguagePage languagePageObj = new LanguagePage();
        }
    }
}
