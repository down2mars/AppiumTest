using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using System.Diagnostics;
using System.ComponentModel;
using AppiumTest.UIActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppiumTest
{
    public class AppiumService
    {
        public static WindowsDriver<WindowsElement> session;
        private readonly AppiumLocalService appiumLocalService = new AppiumServiceBuilder().UsingPort(4723).Build();

        public AppiumService StartAppium()
        {
            if (appiumLocalService == null)
            {
                appiumLocalService.Start();

                Assert.IsTrue(appiumLocalService.IsRunning);
            }
         
            return this;
        }

        public AppiumService StopAppium()
        {
            if (appiumLocalService != null)
            {
                appiumLocalService.Dispose();                
                Assert.IsFalse(appiumLocalService.IsRunning);   
            }
            return this;
        }

        public AppiumService LaunchApp(string path)
        {
            StartAppium();
            AppiumOptions capabilities = new AppiumOptions();            
            capabilities.AddAdditionalCapability("app", path);            
            
            WindowsDriver<WindowsElement> _session = new WindowsDriver<WindowsElement>(appiumLocalService, capabilities);           
            

            session = _session;
            
            return this;
        }
        
    }   
    
}
