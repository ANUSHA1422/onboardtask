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
   public class DescriptionTests:CommonDriver
    {

        [Test, Order(1)]
        public void AddDescriptionTest()
        {
            DescriptionPage descriptionPageObj = new DescriptionPage();
            descriptionPageObj.AddDescription();
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
