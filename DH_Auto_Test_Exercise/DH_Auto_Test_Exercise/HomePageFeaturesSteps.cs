using System;
using TechTalk.SpecFlow;

//Hereby the libraries needed to trigger Selenium on Chrome
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//Additional libraries
using DH_Auto_Test_Exercise.DHPages;
using System.Diagnostics;

namespace DH_Auto_Test_Exercise
{


    [Binding]
    public class HomePageFeaturesSteps
    {

        //Declare objects
        IWebDriver driver = new ChromeDriver(@"C:\browserdrivers\chromedriver\");
        DHHomePage objDHHomePage;
        DHFormPage objDHFormPage;
        DHSiteCommons objDHSiteCommons;

        //---------------------------------------------------------------------------------------------

        [Given(@"I am on the DH UI Testing home website")]
        public void GivenIAmOnTheDHUITestingHomeWebsite()
        {
            driver.Url = "http://uitest.duodecadits.com";
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"the title of the site UI Testing is visible")]
        [Given(@"the title of the site UI Testing is visible")]
        public void GivenTheTitleUITestingIsVisible()
        {
            objDHSiteCommons.CheckTitleSite();
        }

        //---------------------------------------------------------------------------------------------

        [When(@"I click on button (.*)")]
        public void WhenIClickOnButtonForm(String button)
        {
            objDHSiteCommons.ClickkOnSiteButton(button);
        }

        //---------------------------------------------------------------------------------------------

        [When(@"the DH logo is visible")]
        public void TheDHlogoIsVisible()
        {
            Debug.Assert(objDHSiteCommons.IsImageLogoVisible());
        }

    }
}
