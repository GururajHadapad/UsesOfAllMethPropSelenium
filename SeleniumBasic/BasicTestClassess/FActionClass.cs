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
            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Actions");
          //  driver.Navigate().GoToUrl("https://www.vtiger.com/");
           Actions  action= new Actions(driver);
            

            IWebElement path1 = driver.FindElement(By.XPath("//li[@name='one']"));
            IWebElement path2 = driver.FindElement(By.XPath("//li[@name='four']"));
            //Build();--it will work /or it will start working of mouse action where currently mouse cursor/pointer is present
            //perform(); it is a method in actions class which will just perform action where currently mouse cursor/pointer is present
            //IWebElement productdropdown = driver.FindElement(By.XPath("//a[contains(text(),'Products')]"));

            //****************** movetoelement ***********************//

            // action.MoveToElement().Build().Perform();
            //action.MoveToElement(productdropdown,20,20).Build().Perform();
            //action.MoveToElement(productdropdown, 20, 20).Build().Perform();

            

            //********************* click() ************************//
            // action.Click().Build().Perform();
            //action.Click(productdropdown).Build().Perform();// it will click on particular webelement which is provided in the parameter

            //*********************** Doubleclick ***********************//
            // IWebElement twoclick = driver.FindElement(By.XPath("//img[@id='websense-chat-icon']"));
            // action.DoubleClick().Build().Perform();// it should be used like first use move to element to particular element and then use this method
            // action.DoubleClick(twoclick).Build().Perform();

            //*********************** clickAndHold  and release method ********************//
            // action.ClickAndHold();
            // action.ClickAndHold(path1).MoveToElement(path2).Release(path2).Build().Perform();  

            //*********************** contextclick ********************//
            // action.ContextClick();
            // action.ContextClick(path2).Build().Perform();

            //*********************** MoveByOffset ********************//
           // action.ClickAndHold(path2).MoveByOffset(60, 20).Build().Perform();

            //*********************** DragAndDrop DragAndDropByOffSet ********************//
            IWebElement source = driver.FindElement(By.XPath("//div[@id='draggable']"));
            IWebElement target = driver.FindElement(By.XPath("//div[@id='droppable']"));
            // action.DragAndDrop(source, target).Build().Perform();
            //drag and drop byOffset method will it will take one element from particular place and then it will drop at particular cordinates which is mentioned
            // action.DragAndDropToOffset(source,20,20).Build().Perform();

            //***********************  ********************//

            driver.Quit();
        }
    }
}
