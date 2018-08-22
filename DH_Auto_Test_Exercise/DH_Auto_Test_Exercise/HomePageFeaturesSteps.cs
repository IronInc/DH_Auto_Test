using System;
using TechTalk.SpecFlow;

//Hereby the libraries needed to trigger Selenium on Chrome
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DH_Auto_Test_Exercise
{


    [Binding]
    public class HomePageFeaturesSteps
    {
        private IWebDriver driver = new ChromeDriver(@"C:\browserdrivers\chromedriver\");

        //---------------------------------------------------------------------------------------------

        [Given(@"I am on the DH UI Testing home website")]
        public void GivenIAmOnTheDHUITestingHomeWebsite()
        {
            driver.Url = "http://uitest.duodecadits.com";
        }

        //---------------------------------------------------------------------------------------------

        [Then(@"the title (.*) is visible")]
        [Given(@"the title (.*) is visible")]
        public void GivenTheTitleUITestingIsVisible(String title)
        {
            driver.FindElement(By.Id(title));
        }

        //---------------------------------------------------------------------------------------------

        [When(@"I click on button (.*)")]
        public void WhenIClickOnButtonForm(String button)
        { 
           driver.FindElement(By.Id(button)).Click();
           
        }

        //---------------------------------------------------------------------------------------------

    }
}
