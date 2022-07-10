using MarsProject2022.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject2022.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        LogInPage LogInPageObj = new LogInPage();

        public void LoginActions()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //login page object initialization and definition
            LogInPage loginpageObj = new LogInPage();
            loginpageObj.LoginSteps(driver);

        }

        public void CloseTestRun()
        {
            driver.Quit();
        }


    }
}
