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

namespace AppiumTest.UIActions
{
    public class CommonActions
    {
        //private WindowsElement GetButton(string buttonName)
        //{
        //    Assert.IsNotNull(buttonName, "Cannot click button because buttonName is Null");

        //    WindowsElement button = AppiumService.session.FindElementByAccessibilityId(buttonName);
        //    Assert.IsTrue(button.Enabled.Equals(true), "cannot click the button " + buttonName + " because it is not enabled");

        //    return button;
        //}


        public CommonActions ClickButton(string buttonName)
        {
            WindowsElement button = Button.GetButton(buttonName);

            button.Click();

            return this;
        }
    }
}
