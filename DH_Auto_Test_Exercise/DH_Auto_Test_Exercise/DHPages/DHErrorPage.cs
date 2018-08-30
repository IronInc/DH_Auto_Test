using System;
using System.Collections.Generic;
using System.Text;

// Additional libraries for assertions and to trigger Selenium under Chrome
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DH_Auto_Test_Exercise.DHPages
{
    class DHErrorPage
    {
        //This class contains elements and functions related to the Error page

        IWebDriver driver;

        String errorMessage = "404 Error: File not found :-(";

        By errorMessageLoc = By.XPath("//h1");

        //we get the driver on the constructor
        public DHErrorPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CheckErrorPageMessage()
        {
            //Check the error message is shown

            Debug.Assert(errorMessage.Equals(driver.FindElement(errorMessageLoc).Text));
        }


    }
}
