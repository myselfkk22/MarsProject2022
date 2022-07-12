using MarsProject2022.Pages;
using MarsProject2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsProject2022.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinition : CommonDriver
    {
        [After]
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }

        [Given(@"I logged into the Mars portal\.")]
        public void GivenILoggedIntoTheMarsPortal_()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //login page object initialization and definition
            LogInPage loginpageObj = new LogInPage();
            loginpageObj.LoginSteps(driver);

        }

        //Language

        [When(@"I add language on my profile\.")]
        public void WhenIAddLanguageOnMyProfile_()
        {
            //Seller Language page Initialization and definition
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.addLanguage(driver);
        }

        [Then(@"The language should be added successfully\.")]
        public void ThenTheLanguageShouldBeAddedSuccessfully_()
        {
            //Seller Language page Initialization and definition
            LanguagePage languagePageObj = new LanguagePage();
            string newLanguage = languagePageObj.GetNewLanguage(driver);
            string newLanguageLevel = languagePageObj.GetNewLanguageLevel(driver);
            // Assertion
            Assert.That(newLanguage == "English", "Actual language and Expected language do Not match");
            Assert.That(newLanguageLevel == "Fluent", "Actual language level and Expected language level do Not match");
        }
          
        [When(@"I edit '([^']*)' and '([^']*)' on an excisting language record\.")]
        public void WhenIEditAndOnAnExcistingLanguageRecord_(string p0, string p1)
        {
                //Seller Language page Initialization and definition
                LanguagePage languagePageObj = new LanguagePage();
                languagePageObj.editLanguage(driver, p0, p1);
        }


        [Then(@"The record should have the edited '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheEdited(string p0, string p1)
        {
                //Seller Language page Initialization and definition
                LanguagePage languagePageObj = new LanguagePage();

                string editNewLanguage = languagePageObj.GetEditNewLanguage(driver);
                string editNewLanguageLevel = languagePageObj.GetEditNewLanguageLevel(driver);
                // Assertion
                Assert.That(editNewLanguage == p0, "Actual language and Expected language do Not match");
                Assert.That(editNewLanguageLevel == p1, "Actual language level and Expected language level do Not match");
        }

        [When(@"I delete a language from an existing language record\.")]
        public void WhenIDeleteALanguageFromAnExistingLanguageRecord_()
        {
                //Seller Language page Initialization and definition
                LanguagePage languagePageObj = new LanguagePage();
                languagePageObj.deleteLanguage(driver);
        }


         [Then(@"The language record should be deleted successfully\.")]
         public void ThenTheLanguageRecordShouldBeDeletedSuccessfully_()
         {

                //Seller Language page Initialization and definition
                LanguagePage languagePageObj = new LanguagePage();
                string deleteLanguageIcon = languagePageObj.GetDeleteLanguageIcon(driver);
                // Assertion
                Assert.That(deleteLanguageIcon != "Telugu", "Sellor record has not been deleted successfully.");

         }

    }
}
