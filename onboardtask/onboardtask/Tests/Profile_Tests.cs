
using onboardtask.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using onboardtask.Utilities;

namespace onboardtask.Tests
{
    [TestFixture]
    public class Profile_Tests:CommonDriver
    {
       
        [SetUp]
        public void SignInActions()
        {
            IWebDriver driver = new ChromeDriver();

            SignInPage signinPageObj = new SignInPage();
            signinPageObj.SignInSteps(driver);

        }
        [Test,Order(1)]
        public void AddDescription()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddDescription(driver);
        }
        [Test,Order(2)]
        public void AddLanguage()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddLanguage(driver);

        }
        [Test, Order(3)]
        public void AddSkill()
        {
            ProfilePage profilepageobj = new ProfilePage();
            profilepageobj.AddSkill(driver);

        }
        [TearDown, OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }


    }
   
   










}


