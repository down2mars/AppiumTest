using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumTest.CommonActions
{
    public class Launch
    {
        public void static LaunchBrowser()
        {
            var appiumLocalService = new AppiumServiceBuilder().UsingPort(4723).Build();
            appiumLocalService.Start();

            AppiumOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability("app", @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");

            WindowsDriver<WindowsElement> session = new WindowsDriver<WindowsElement>(appiumLocalService, capabilities);


            String winowHandle = session.CurrentWindowHandle;

            return this;
        }
    }
}
