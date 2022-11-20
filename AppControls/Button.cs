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


namespace AppiumTest
{
    public class Button : AppiumService
    {
        //Browser ribbon buttons
        public static string back = "Back";
        public static string refresh = "Refresh";
        public static string home = "view_1004";
        public static string sharePage = "";
    } 
}
