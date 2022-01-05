using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumBasic.BaseClass;
using System.Drawing;

namespace SeleniumBasic.BasicTestClassess
{
    [TestFixture]
     class BManageWindow :LoggersClass
    {
        [Test]
        public void minimizeWindow()
        {
            driver.Manage().Window.Minimize();
        }
        [Test]
        public void maximizeWindow()
        {
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
        }
        [Test]
        public void FullScreenWindow()
        {
            driver.Manage().Window.FullScreen();
            Thread.Sleep(5000);
        }

        [Test]
        public void setAndGetWindowPosition()
        {
            Point pobefore = driver.Manage().Window.Position;
            Console.WriteLine(pobefore);
            Thread.Sleep(5000);
            driver.Manage().Window.Position = new Point(400, 200);
            Thread.Sleep(5000);
            Point polater = driver.Manage().Window.Position;
            Console.WriteLine(polater);
        }
        [Test]
        public void setAndGetWindowSize()
        {
            Size sibefore= driver.Manage().Window.Size;
            Console.WriteLine(sibefore);
            Thread.Sleep(5000);
            driver.Manage().Window.Size= new Size(800, 200);
            Thread.Sleep(5000);
            Size silater= driver.Manage().Window.Size;
            Console.WriteLine(silater);
        }
    }
}
