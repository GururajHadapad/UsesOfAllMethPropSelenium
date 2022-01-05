using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumBasic.BasicTestClassess
{
     class DXpathFunctions
    {
        
        //text()
        //starts-with()
        //contains()
        //not()
        //last()
        //position()

        [Test]
        public void xPathFunctionsUseage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.actitime.com/");
            Thread.Sleep(4000);
            //usage of XPATH text() function
           IWebElement feature=driver.FindElement(By.XPath("//span[text()='Features']"));
            Console.WriteLine(feature.Text);
            //usage of XPATH starts-with() function
            driver.FindElement(By.XPath("//div[starts-with(@class,'header')]"));
            //usage of XPATH contains() function
            driver.FindElement(By.XPath("//div[contains(@class,'header__menu')]"));

            driver.Quit();  
        }
     }
}
