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
        IWebDriver driver;

        By activeForm = By.XPath("//li[@class='active']/a[@id='form']");

        String formMessage = "Simple Form Submission";

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
            Debug.Assert(formMessage.Equals(driver.FindElement(formMessageLoc).Text));
        }

        public Boolean isFormPageActive()
        {

            return driver.FindElement(activeForm).Displayed;

        }

        public void CheckInputBox()
        {
            Debug.Assert(driver.FindElement(inputBox).Displayed);
        }

        public void CheckInputButton()
        {
            Debug.Assert(driver.FindElement(inputButton).Displayed);
        }

        public void EnterValue(String text)
        {
            driver.FindElement(inputBox).SendKeys(text);
        }

        public void ClickOnSubmitButton()
        {
            driver.FindElement(inputButton).Click();
        }

    }
}