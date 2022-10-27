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
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 9);
            IWebElement WriteDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            WriteDescription.Click();
           // WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 9);

           // WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 13);
            IWebElement Description = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            Description.Click();
            Description.Clear();
            
            Description.SendKeys("HELLO");

            IWebElement SaveButton = driver.FindElement(By.XPath("//button[@type='button']"));
            SaveButton.Click();

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//span[@style='padding-top: 1em;']", 9);
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
