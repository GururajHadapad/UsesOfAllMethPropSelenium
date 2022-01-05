using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace SeleniumBasic.BasicWebelementProperties
{
     class FindElementAndElements
    {[Test]
        public void diffFindEleAndFindEleMents() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demowf.aspnetawesome.com/";
            
            //return type for findelement
            //used to identify one element
            IWebElement fe = driver.FindElement(By.XPath("//a"));
            //reading of element of find element
            //if element is not found it will give no such element exception
            Console.WriteLine(fe.Text);



            //return type for findelements
            //used to identify multiple element
            ReadOnlyCollection<IWebElement> fes = driver.FindElements(By.XPath("//a"));
            Console.WriteLine(fes.Count());
            //reading of element of find elements
            //if element is not found it will give 0 list/empty list
            foreach (IWebElement ele in fes) 
            {
                Console.WriteLine(ele.Text);
            }
            driver.Quit();  
        }
    }
}
