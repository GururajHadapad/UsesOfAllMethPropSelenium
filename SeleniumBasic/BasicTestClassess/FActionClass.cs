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

namespace SeleniumBasic.BasicTestClassess
{
     class FActionClass
    {
        [Test]
        public void actionMoveToElement()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.vtiger.com/");
         Actions  action= new Actions(driver);
            //Build();--it will work /or it will start working of mouse action where currently mouse cursor/pointer is present
            //perform(); it is a method in actions class which will just perform action where currently mouse cursor/pointer is present
            IWebElement productdropdown = driver.FindElement(By.XPath("//a[contains(text(),'Products')]"));

            //****************** movetoelement ***********************//
            //action.MoveToElement(productdropdown).Build().Perform();
            //action.MoveToElement(productdropdown,20,20).Build().Perform();
            //action.MoveToElement(productdropdown, 20, 20).Build().Perform();

            //********************* click() ************************//
            // action.Click().Build().Perform();
            //action.Click(productdropdown).Build().Perform();// it will click on particular webelement which is provided in the parameter

            //*********************** Doublrclick ***********************//
            IWebElement twoclick = driver.FindElement(By.XPath("//img[@id='websense-chat-icon']"));
            // action.DoubleClick().Build().Perform();// it should be used like first use move to element to particular element and then use this method
            // action.DoubleClick(twoclick).Build().Perform();

        }
    }
}
