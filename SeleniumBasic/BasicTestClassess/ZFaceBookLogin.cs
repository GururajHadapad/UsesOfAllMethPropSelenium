using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumBasic.BaseClass;
using System.Threading;

namespace SeleniumBasic
{
    [TestFixture]
    public class Tests : LoggersClass

    { 
        [Test]
        public void login()
        {
           // Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("gururajhadapad2@gmail.com");
           // Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@id='pass']")).SendKeys("911guru1457");
           // Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@name='login']")).Click();
          // Thread.Sleep(10000);
          //  driver.FindElement(By.XPath("//button[@class='_42ft _4jy0 _9kpt _4jy5 _4jy1 selected _51sy']")).Click();



        }
    } 
}