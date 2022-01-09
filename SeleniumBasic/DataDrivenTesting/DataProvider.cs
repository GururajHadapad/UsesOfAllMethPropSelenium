using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.DataProvider
{
    [TestFixture]
    public class DataProvider
    {
        [Test]
        [TestCaseSource("dataDrivenTest")]

        public void logClass(string urls) 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = urls;
            driver.Quit();
        }
        //note data providing method should be static
        static IList dataDrivenTest() 
        {
            ArrayList list = new ArrayList();
            list.Add("https://facebook.com/");
            list.Add("https://www.makemytrip.com/");
            list.Add("https://github.com/");

            return list;
        }
    }
}
