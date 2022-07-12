using MarsProject2022.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject2022.Utilities
{
    [TestFixture]
    public class CommonDriver
    {
       
        public  IWebDriver driver;

        LogInPage LogInPageObj = new LogInPage();

        [OneTimeSetUp]
        public void LoginActions()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //login page object initialization and definition
            LogInPage LogInPageObj = new LogInPage();
            LogInPageObj.LoginSteps(driver);

        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }


    }
}
