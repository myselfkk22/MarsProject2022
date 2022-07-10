using MarsProject2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject2022.Pages
{
    public class LogInPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            //Launch Mars portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 2);
            try
            {
                //Identify SignIn button and click 
                IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                signInButton.Click();

                //Identify Email adderss text box and enter valid Email address
                IWebElement EmailAddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                EmailAddress.SendKeys("myselfkk22@gmail.com");

                //Identify password text box and enter valid password
                IWebElement passwordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextBox.SendKeys("Mars@1234");

                //Identify ligIn button and click
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();


            }
            catch (Exception ex)
            {
                Assert.Fail("Mars home page did not launch.", ex.Message);
            }

        }




    }

}


