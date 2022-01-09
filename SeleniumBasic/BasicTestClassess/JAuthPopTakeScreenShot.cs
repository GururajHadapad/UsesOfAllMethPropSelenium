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

namespace SeleniumBasic.BasicTestClassess
{
     class JAuthPopTakeScreenShot
    {
        //[Test]
        //public void authenticcationPopUp()
        //{
        //    IWebDriver driver=new ChromeDriver();
        //   driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/basic_auth");
        //    // driver.Navigate().GoToUrl("https://admin:admin@the-internet.herokuapp.com/basic_auth");
        //   // driver.SwitchTo().Alert().SetAuthenticationCredentials("admin","admin");
        //}

        [Test]
        public void takeScreenShot()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            Thread.Sleep(1000);
            ITakesScreenshot ts = ((ITakesScreenshot)driver);
            ts.GetScreenshot().SaveAsFile("Test1.png",ScreenshotImageFormat.Png);
            // To see the taken screenshot 
            //Right click on project
            // 1 Select option Open Folder in File Explorer
            //2 Bin --> Debug --> .Net 6.0 --> <Name provided>(Test1.png)
            driver.Quit();
        }
    }
}
