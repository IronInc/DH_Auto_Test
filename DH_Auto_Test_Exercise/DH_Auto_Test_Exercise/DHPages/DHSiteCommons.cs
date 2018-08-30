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
        // This class contains common elements and functions that don't belong to a specific page

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

        public void ClickOnSiteButton(String site)
        {
            //This function clicks on a button located on the header

            Console.WriteLine("HOLA: " + site);

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
                Console.WriteLine("WRONG OPTION: " + site);
                Debug.Assert(false);
            }


        }


        //Find the site title and verify if correct

        public void CheckTitleSite()
        {
            //This function finds the title and checks its name

            String detectText = driver.FindElement(idSite).Text;
            Debug.Assert(siteHeader.Equals(detectText));

        }


        public Boolean IsImageLogoVisible()
        {
            //This checks whether the logo is visible

            return driver.FindElement(imageLogo).Displayed;
        }
    }
}
