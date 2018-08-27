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
            Debug.Assert(homeMessage.Equals(driver.FindElement(homeMessageLoc).Text));
        }

        public void checkHomePageDescMessage()
        {
            Debug.Assert(homeMessageDesc.Equals(driver.FindElement(homeMessageDescLoc).Text));
        }

        public Boolean IsHomePageActive()
        {

            return driver.FindElement(activeHome).Displayed;

        }

        public Boolean IamOnHomePage()
        {
            String url = driver.Url;
            return url.Equals(urlHome);
        }


    }
}
