using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace SeleniumBasic.BasicWebelementProperties
{
     class PropertiesOfWebelement
    {
        [Test]
        public void webelementProperties() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demowf.aspnetawesome.com/";
            
            bool logo = driver.FindElement(By.XPath("//a[@id='btnLogo']")).Displayed;
            Console.WriteLine(logo);
            bool enable = driver.FindElement(By.XPath("//a[text()='Home']")).Enabled;
            Console.WriteLine(enable);
            Point location = driver.FindElement(By.XPath("//a[text()='Home']")).Location;
            Console.WriteLine(location);
            Size size = driver.FindElement(By.XPath("//a[text()='Home']")).Size;
            Console.WriteLine(size);
            string tagname = driver.FindElement(By.XPath("//a[text()='Home']")).TagName;
            Console.WriteLine(tagname);
            string text = driver.FindElement(By.XPath("//a[text()='Home']")).Text;
            Console.WriteLine(text);
            driver.Quit();
        }
        
    }
}
