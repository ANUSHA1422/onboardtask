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
    public class DescriptionPage : CommonDriver
    {
        public void AddDescription()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//i[@class='outline write icon']", 9);
            IWebElement WriteDescription = driver.FindElement(By.XPath("//i[@class='outline write icon']"));
            WriteDescription.Click();
            IWebElement Description = driver.FindElement(By.XPath("//div/section[2]//div[3]/div/div/form//div[2]/div[1]/textarea"));
            Description.Click();
            Description.Clear();
            Thread.Sleep(1000);
            Description.SendKeys("HELLO");

            IWebElement SaveButton = driver.FindElement(By.XPath("//button[@type='button']"));
            SaveButton.Click();

            Thread.Sleep(1000);
            IWebElement newDescription = driver.FindElement(By.XPath("//span[@style='padding-top: 1em;']"));
            Assert.That(newDescription.Text != "HELLO", "actual description and expected description do not  match");

        }
        public string GetDescription()
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//span[@style='padding-top: 1em;']"));
            return newDescription.Text;
        }





    }



        

   



}
