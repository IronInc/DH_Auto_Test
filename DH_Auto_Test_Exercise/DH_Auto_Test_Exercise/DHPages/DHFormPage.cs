using System;
using System.Collections.Generic;
using System.Text;

// Additional libraries for assertions and to trigger Selenium under Chrome
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DH_Auto_Test_Exercise
{
    class DHFormPage
    {
        //This class contains elements and operations related to the Form page

        IWebDriver driver;

        By activeForm = By.XPath("//li[@class='active']/a[@id='form']");

        String formMessage = "Simple Form Submission";
        String urlForm = "http://uitest.duodecadits.com/form.html";

        By formMessageLoc = By.XPath("//div[@class='ui-test']/h1");

        By inputBox = By.Name("myName");
        By inputButton = By.Id("hello-submit");

        //we get the driver on the constructor
        public DHFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CheckFormPageMessage()
        {
            //This checks the text that should show on the Form page's header text

            Debug.Assert(formMessage.Equals(driver.FindElement(formMessageLoc).Text));
        }

        public Boolean IsFormPageActive()
        {
            //Returns true if the Form button is active

            return driver.FindElement(activeForm).Displayed;

        }

        public void CheckInputBox()
        {
            //This checks the input box is visible

            Debug.Assert(driver.FindElement(inputBox).Displayed);
        }

        public void CheckInputButton()
        {
            //This checks the input button is visible

            Debug.Assert(driver.FindElement(inputButton).Displayed);
        }

        public void EnterValue(String text)
        {
            //This sends a string in the input box

            driver.FindElement(inputBox).SendKeys(text);
        }

        public void ClickOnSubmitButton()
        {
            //This clicks on the input button

            driver.FindElement(inputButton).Click();
        }

        public Boolean IamOnFormPage()
        {
            //This checks form page is loaded

            String url = driver.Url;
            return url.Equals(urlForm);
        }

    }
}