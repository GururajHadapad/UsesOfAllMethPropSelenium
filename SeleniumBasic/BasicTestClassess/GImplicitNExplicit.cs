using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumBasic.BasicTestClassess
{
     class GImplicitNExplicit
    {
        public void implicitWait()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.vtiger.com/");
           

            //****************************** Implicit Wait ********************//
            //first show with correct xpath and then intentionly give wrong xpath so that implicit wait should wait for given time
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          
            //************************* Explicit Wait *****************************//
            //Before using "Expected conditions" class add nuget package called "DotNetSeleniumExtras.WaitHelpers" and then Write expected conditions manually and import selenium.waithelpers
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible((By.Id("websense-chat-icon"))));

            //************************ PageLoad *****************************//
           // driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);


            driver.FindElement(By.Id("websense-chat-icon")).Click();
           // Thread.Sleep(4000);
            driver.Quit();

        }
    }
}
