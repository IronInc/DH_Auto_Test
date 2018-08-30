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
    public class DHSteps
    {
         IWebDriver driver;
          DHHomePage objDHHomePage;
          DHFormPage objDHFormPage;
          DHHelloPage objDHHelloPage;
          DHErrorPage objDHErrorPage;
          DHSiteCommons objDHSiteCommons;

            [Before]
            public void SetUp()
            {
            //Declare objects

            driver = new ChromeDriver(@"C:\browserdrivers\chromedriver\");
            objDHHomePage = new DHHomePage(driver);
            objDHFormPage = new DHFormPage(driver);
            objDHHelloPage = new DHHelloPage(driver);
            objDHErrorPage = new DHErrorPage(driver);
            objDHSiteCommons = new DHSiteCommons(driver);
            driver.Manage().Window.Maximize();
            }

            


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
            objDHSiteCommons = new DHSiteCommons(driver);
            objDHSiteCommons.CheckTitleSite();
        }

        //---------------------------------------------------------------------------------------------

        [When(@"I click on button (.*)")]
        public void WhenIClickOnButtonForm(string button)
        {
            objDHSiteCommons = new DHSiteCommons(driver);
            objDHSiteCommons.ClickOnSiteButton(button);
        }

        //---------------------------------------------------------------------------------------------

        [Given(@"the DH logo is visible")]
        [Then(@"the DH logo is visible")]
        public void TheDHlogoIsVisible()
        {
            objDHSiteCommons = new DHSiteCommons(driver);
            Debug.Assert(objDHSiteCommons.IsImageLogoVisible());
        }


        //---------------------------------------------------------------------------------------------

        [Then(@"(.*) page is active")]
        public void HomePageIsActive(String text)
        {
            if (text.Equals("home"))
            {
                objDHHomePage = new DHHomePage(driver);
                Debug.Assert(objDHHomePage.IsHomePageActive());
            }
            else if (text.Equals("form"))
            {
                objDHFormPage = new DHFormPage(driver);
                Debug.Assert(objDHFormPage.IsFormPageActive());
            }
            else //WRONG OPTION 
            {
                Console.WriteLine("WRONG OPTION");
                Debug.Assert(false);
            }
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"I am on (.*) page")]
        public void IamOnPage(String site_type)
        {
            objDHHomePage = new DHHomePage(driver);
            objDHFormPage = new DHFormPage(driver);


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
            objDHHomePage = new DHHomePage(driver);
            objDHHomePage.checkHomePageMessage();
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"the text in p should read (.*)")]
        public void TextInPShouldRead(String text)
        {
            objDHHomePage = new DHHomePage(driver);

            objDHHomePage.checkHomePageDescMessage();
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"the input box is visible")]
        public void InputBoxVisible()
        {
            objDHFormPage = new DHFormPage(driver);
            objDHFormPage.CheckInputBox();
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"the input button is visible")]
        public void InputButtonVisible()
        {
            objDHFormPage = new DHFormPage(driver);
            objDHFormPage.CheckInputButton();
        }

        [When(@"I enter value (.*) in the input box")]
        public void EnterValueInput(String value)
        {
            objDHFormPage = new DHFormPage(driver);
            objDHFormPage.EnterValue(value);
        }

        [When(@"I submit the form")]
        public void ISubmitForm()
        {
            objDHFormPage = new DHFormPage(driver);
            objDHFormPage.ClickOnSubmitButton();
        }

        [Then(@"I check the hello page with (.*) is displayed")]
        public void ICheckHello(String value)
        {
            objDHHelloPage = new DHHelloPage(driver);
            Debug.Assert(objDHHelloPage.CheckHelloMessage(value));
        }

        [Then(@"I check a 404 error is displayed")]
        public void A404ErrorDisplayed()
        {
            objDHErrorPage = new DHErrorPage(driver);
            objDHErrorPage.CheckErrorPageMessage();
        }

        //--------------------------------------Additional functions


        [After]
        public void CloseBrowser()
        {
            System.Console.WriteLine("Execute AfterScenario- CloseBrowser");
            driver.Close();           
        }



    }
}
