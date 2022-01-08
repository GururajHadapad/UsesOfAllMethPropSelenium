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
     class JAuthenticationPop
    {
        [Test]
        public void authenticcationPopUp()
        {
            IWebDriver driver=new ChromeDriver();
           driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/basic_auth");
            // driver.Navigate().GoToUrl("https://admin:admin@the-internet.herokuapp.com/basic_auth");
        }
    }
}
