using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumBasic.DataDrivenTesting
{
    [TestFixture]
    class DataRowDriven
    {
        [Test]
        [DataRow("guru","12345")]
        [DataRow("gururaj","1234556")]
        [DataRow("gururajhadapad2@gmail.com","911guru1457")]
        public void DataDrivenByDataRow(string Fname, string Pwd)
        {
         IWebDriver  driver= new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Timeouts().ImplicitWait=(TimeSpan.FromSeconds(5));   
            driver.FindElement(By.Id("email")).SendKeys(Fname);
            driver.FindElement(By.Id("pass")).SendKeys(Pwd);
            driver.FindElement(By.Name("login")).Click();
            driver.Quit();
        }
    }
}
