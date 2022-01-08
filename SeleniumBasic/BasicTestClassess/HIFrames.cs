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
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.BasicTestClassess
{
    class HIFrames
    {
        [Test]
        public void switchingFrames()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/Hp/Desktop/page1.html");
            //********************* Switch frame by index **********************//
            //driver.SwitchTo().Frame(0);
            //driver.FindElement(By.Id("t2")).SendKeys("two");
            //Thread.Sleep(2000);
            //driver.SwitchTo().Frame(0);
            //driver.FindElement(By.Id("t3")).SendKeys("3frame");
            //Thread.Sleep(2000);
            //driver.SwitchTo().ParentFrame();
            //driver.FindElement(By.Id("t2")).Clear();
            //Thread.Sleep(2000);
            //driver.FindElement(By.Id("t2")).SendKeys("two2");

            //************************* Switch Frame by Web Element *****************//

            //IWebElement frame1 = driver.FindElement(By.Id("f1"));
            // driver.SwitchTo().Frame(frame1);
            // driver.FindElement(By.Id("t2")).SendKeys("two");
            //Thread.Sleep(2000);
            //IWebElement frame2 = driver.FindElement(By.Id("f2"));
            //driver.SwitchTo().Frame(frame2);
            //driver.FindElement(By.Id("t3")).SendKeys("3frame");
            //driver.SwitchTo().ParentFrame();
            //driver.FindElement(By.Id("t2")).Clear();
            //driver.FindElement(By.Id("t2")).SendKeys("two2");

            //*************************** Switch Frame by string *******************//

            driver.SwitchTo().Frame("f1");
            driver.FindElement(By.Id("t2")).SendKeys("two");
            Thread.Sleep(2000);
            driver.SwitchTo().Frame("f2");
            driver.FindElement(By.Id("t3")).SendKeys("3frame");
            driver.SwitchTo().ParentFrame();
            driver.FindElement(By.Id("t2")).Clear();
            driver.FindElement(By.Id("t2")).SendKeys("two2");

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
