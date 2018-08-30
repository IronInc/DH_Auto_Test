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
        //This class contains elements and functions related to the Hello page

        IWebDriver driver;
        By helloLoc = By.Id("hello-text");

        public DHHelloPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Boolean CheckHelloMessage(String name)
        {
            //Check Hello message followed by the name shows up.

            return driver.FindElement(helloLoc).Text.Equals("Hello " + name + "!");
        }
    }
}
