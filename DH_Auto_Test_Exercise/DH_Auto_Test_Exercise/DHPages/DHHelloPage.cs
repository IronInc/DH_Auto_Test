using System;
using System.Collections.Generic;
using System.Text;

// Additional libraries for assertions and to trigger Selenium under Chrome
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DH_Auto_Test_Exercise.DHPages
{
    class DHHelloPage
    {
        IWebDriver driver;
        By helloLoc = By.Id("hello-text");

        public Boolean CheckHelloMessage(String name)
        {
            return driver.FindElement(helloLoc).Text.Equals("Hello " + name + "!");
        }
    }
}
