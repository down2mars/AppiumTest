using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using System.Diagnostics;
using System.ComponentModel;
using AppiumTest.UIActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppiumTest.AppControls;

namespace AppiumTest.Tests
{
    internal class BasicTests
    {
        [ClassInitialize]
        public void ClassInit()
        {
            new AppiumService()
                .StopAppium();
        }

        [ClassCleanup]
        public void ClassCleanup()
        {
            new AppiumService()
                .StopAppium();
        }

        [TestMethod]
        public void LaunchBrowser()
        {
            new AppiumService()
                .StartAppium()
                .LaunchApp(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");
        }



    }
}
