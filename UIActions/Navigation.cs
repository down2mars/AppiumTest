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

namespace AppiumTest.AppControls
{
    public class Navigation : AppiumService
    {

        public void OpenUrl(string url)
        {
            session.Navigate().GoToUrl(url);          
            
            //WindowsElement searchBar = session.FindElementByName("Address and search bar");
            //searchBar.Click();
            //searchBar.SendKeys(url + Keys.Enter);
        }
    }
}