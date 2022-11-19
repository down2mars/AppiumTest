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


namespace AppiumTest
{
    internal class Program
    {       

        static void Main(string[] args)
        {
            new AppiumService()
                .StopAppium()
                .LaunchApp(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");
            new Navigation()
                .OpenUrl(@"https://pugsfanclub.com/");
            new CommonActions()
                .ClickButton(Button.home)
                .ClickButton("PUG DOGS IMAGES");

        }
    }
}