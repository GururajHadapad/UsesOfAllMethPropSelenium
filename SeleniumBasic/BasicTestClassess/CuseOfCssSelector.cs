using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.BasicTestClassess
{
     class CuseOfCssSelector
    {
        [Test]
        public void cssSelector() 
        {

            //this class is used to show using cssSelector to get number of tagnames present

         IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            string pwin = driver.CurrentWindowHandle;
            ReadOnlyCollection<string> cwin = driver.WindowHandles;
            int count = driver.FindElements(By.CssSelector("*")).Count;//this gives all/number of elements
            Console.WriteLine(count);
            IWebElement countlinks = driver.FindElement(By.CssSelector("a"));
            Console.WriteLine(countlinks);
            int countinput = driver.FindElements(By.CssSelector("input")).Count;//this gives all tag name which starts with input
            Console.WriteLine(countinput);
            ReadOnlyCollection<IWebElement> countfooter = driver.FindElements(By.CssSelector("footer"));
            Console.WriteLine(countfooter);
            driver.Quit();


        }
    }
}
