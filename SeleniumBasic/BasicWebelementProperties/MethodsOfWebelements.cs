using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumBasic.BasicWebelementProperties
{
    
   class MethodsOfWebelements
   {
        [Test]
        public void webelementProperties()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demowf.aspnetawesome.com/";
            driver.FindElement(By.XPath("//button[@id='btnMenuToggle']")).Click();

            IWebElement textfield = driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_Meal']"));
            textfield.SendKeys("guru");
            Thread.Sleep(5000);
            textfield.Clear();
            driver.FindElement(By.XPath("//button[@id='btnMenuToggle']")).Click();
            Thread.Sleep(3000);
            string attribute = driver.FindElement(By.XPath("//button[@id='btnMenuToggle']")).GetAttribute("id");
            Console.WriteLine(attribute);
            string color = driver.FindElement(By.XPath("//a[@id='btnLogo']")).GetCssValue("color");
            Console.WriteLine(color);
            driver.Quit();
            
        }

   }
}
