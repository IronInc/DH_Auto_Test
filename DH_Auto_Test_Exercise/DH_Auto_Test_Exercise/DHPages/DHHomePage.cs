using System;
using System.Collections.Generic;
using System.Text;

// Additional libraries for assertions and to trigger Selenium under Chrome
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DH_Auto_Test_Exercise
{
    class DHHomePage
    {
        //This class contains elements and functions related to the Home page

        IWebDriver driver;

        By activeHome = By.XPath("//li[@class='active']/a[@id='home']");
        String urlHome = "http://uitest.duodecadits.com/";
        String homeMessage = "Welcome to the Docler Holding QA Department";
        String homeMessageDesc = "This site is dedicated to perform some exercises and demonstrate automated web testing.";

        By homeMessageLoc = By.XPath("//div[@class='ui-test']/h1");
        By homeMessageDescLoc = By.XPath("//div[@class='ui-test']/p");

        //we get the driver on the constructor
        public DHHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void checkHomePageMessage()
        {
            //This checks the message of the Home page's header

            Debug.Assert(homeMessage.Equals(driver.FindElement(homeMessageLoc).Text));
        }

        public void checkHomePageDescMessage()
        {
            //This checks the message of the Home page's body text

            Debug.Assert(homeMessageDesc.Equals(driver.FindElement(homeMessageDescLoc).Text));
        }

        public Boolean IsHomePageActive()
        {
            //Returns true if the home page is active

            return driver.FindElement(activeHome).Displayed;

        }

        public Boolean IamOnHomePage()
        {
            //Returns true if the Home page is loaded

            String url = driver.Url;
            return url.Equals(urlHome);
        }


    }
}
