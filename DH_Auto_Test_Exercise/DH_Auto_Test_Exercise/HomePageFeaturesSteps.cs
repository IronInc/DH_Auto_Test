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
        DHHelloPage objDHHelloPage;
        DHErrorPage objDHErrorPage;
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

        [Given(@"the DH logo is visible")]
        [Then(@"the DH logo is visible")]
        public void TheDHlogoIsVisible()
        {
            Debug.Assert(objDHSiteCommons.IsImageLogoVisible());
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"the DH logo is visible")]
        public void CheckIamOnHomePage()
        {
            Debug.Assert(objDHSiteCommons.IsImageLogoVisible());
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"home page is active")]
        public void HomePageIsActive()
        {
            Debug.Assert(objDHHomePage.IsHomePageActive());
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"I am on (.*) page")]
        public void IamOnPage(String site_type)
        {
            if (site_type.Equals("home") | site_type.Equals("site"))
                Debug.Assert(objDHHomePage.IamOnHomePage());
            else if (site_type.Equals("form"))
                Debug.Assert(objDHFormPage.IamOnFormPage());
            else //wrong option 
            {
                Console.WriteLine("WRONG OPTION");
                Debug.Assert(false);
            }

        }

        //---------------------------------------------------------------------------------------------

        [Then(@"the text in h1 should read (.*)")]
        public void TextInH1ShouldRead(String text)
        {
            objDHHomePage.checkHomePageMessage();
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"the text in p should read (.*)")]
        public void TextInPShouldRead(String text)
        {
            objDHHomePage.checkHomePageDescMessage();
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"the input box is visible")]
        public void InputBoxVisible()
        {
            objDHFormPage.CheckInputBox();
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"the input button is visible")]
        public void InputButtonVisible()
        {
            objDHFormPage.CheckInputButton();
        }

        [When(@"I enter value (.*) in the input box")]
        public void EnterValueInput(String value)
        {
            objDHFormPage.EnterValue(value);
        }

        [When(@"I submit the form")]
        public void ISubmitForm()
        {
            objDHFormPage.ClickOnSubmitButton();
        }

        [Then(@"I check the hello page with (.*) is displayed")]
        public void ICheckHello(String value)
        {
            Debug.Assert(objDHHelloPage.CheckHelloMessage(value));
        }

        [Then(@"I check a 404 error is displayed")]
        public void A404ErrorDisplayed()
        {
            objDHErrorPage.checkErrorPageMessage();
        }

    }
}
