using System;
using System.Collections.Generic;
using System.Text;

// Additional libraries for assertions and to trigger Selenium under Chrome
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DH_Auto_Test_Exercise.DHPages
{
    class DHSiteCommons
    {
        IWebDriver driver;

        By idSite = By.Id("site");

        String siteHeader = "UI Testing";

        By idError = By.Id("error");

        By idForm = By.Id("form");

        By idHome = By.Id("home");

        By imageLogo = By.Id("dh_logo");


        public DHSiteCommons(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickkOnSiteButton(String site)
        {

            if (site.Equals("home"))
                driver.FindElement(idHome).Click();
            else if (site.Equals("form"))
                driver.FindElement(idForm).Click();
            else if (site.Equals("error"))
                driver.FindElement(idError).Click();
            else if (site.Equals("site"))
                driver.FindElement(idSite).Click();
            else //error, wrong option 
            {
                Console.WriteLine("WRONG OPTION");
                Debug.Assert(false);
            }


        }


        //Find the site title and verify if correct

        public void CheckTitleSite()
        {

            String detectText = driver.FindElement(idSite).Text;
            Debug.Assert(siteHeader.Equals(detectText));

        }

        //Check whether the logo is visible

        public Boolean IsImageLogoVisible()
        {
            return driver.FindElement(imageLogo).Displayed;
        }
    }
}
