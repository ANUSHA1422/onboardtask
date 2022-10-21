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
    public class SignInTests:CommonDriver
    {

        [Test, Order(1)]
        public void SignInTest()
        {
            SignInPage signinPageObj = new SignInPage();
            signinPageObj.SignInSteps(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
