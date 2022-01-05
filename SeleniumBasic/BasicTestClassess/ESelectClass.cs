using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.BaseClass;


namespace SeleniumBasic.BasicTestClassess
{
    [TestFixture]
    public class ESelectClass : LoggersClass
    {
         

        [Test]
        public void createAccount() 
        {
           driver.FindElement(By.XPath("//a[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']")).Click();
            Thread.Sleep(5000);
            IWebElement date = driver.FindElement(By.XPath("//select[@id='day']"));
            SelectElement sd = new SelectElement(date);
            sd.SelectByIndex(1);

            IWebElement month = driver.FindElement(By.XPath("//select[@id='month']"));
            SelectElement sm = new SelectElement(month);
            sd.SelectByValue("1");

            IWebElement year = driver.FindElement(By.XPath("//select[@id='year']"));
            SelectElement sy = new SelectElement(year);
            sd.SelectByText("2020");
        }
    }
}
