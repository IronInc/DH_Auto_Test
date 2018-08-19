using System;

//Hereby the libraries needed to trigger Selenium on Chrome
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//

namespace DHTestAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting test cases");
            Console.ReadLine();


            IWebDriver driver = new ChromeDriver(@"C:\browserdrivers\chromedriver\");
            driver.Url = "http://www.toolsqa.com";
        }
    }
}
