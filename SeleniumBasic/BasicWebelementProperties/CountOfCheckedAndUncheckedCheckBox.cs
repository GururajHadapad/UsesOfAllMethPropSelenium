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

namespace SeleniumBasic.BasicWebelementProperties
{
     class CountOfCheckedAndUncheckedCheckBox
    {
        [Test]
        public void countCheckedCheckBox() 
        {
        IWebDriver driver=new ChromeDriver();
            driver.Url = "https://demowf.aspnetawesome.com/";
            driver.FindElement(By.XPath("//div[@class='o-chk ']")).Click();
            ReadOnlyCollection<IWebElement> checkboxes = driver.FindElements(By.XPath("((//div[@class='awe-display o-ochk']/ul/li)/label)"));
            Console.WriteLine(checkboxes.Count);
            foreach (IWebElement checkbox in checkboxes) 
            {
                Console.WriteLine( checkbox.Selected);
                if (checkbox.Selected==false) 
                {
                  checkbox.Click();
                }    
            }
            Console.WriteLine("ychdchddjhcbdhbcdhh");

            ReadOnlyCollection<IWebElement> checkboxes1 = driver.FindElements(By.XPath("((//div[@class='awe-display o-ochk']/ul/li)/label)"));
            foreach (IWebElement checkbox in checkboxes1)
            {

                Console.WriteLine(checkbox.Selected);

            }
        }

    }
}
