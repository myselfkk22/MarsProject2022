using MarsProject2022.Pages;
using MarsProject2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsProject2022.StepDefintion
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {

        [Given(@"I logged into the Mars portal\.")]
        public void GivenILoggedIntoTheMarsPortal_()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //login page object initialization and definition
            LogInPage loginpageObj = new LogInPage();
            loginpageObj.LoginSteps(driver);

        }

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

        [Given(@"I logged into the Mars portal successfully\.")]
        public void GivenILoggedIntoTheMarsPortalSuccessfully_()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //login page object initialization and definition
            LogInPage loginpageObj = new LogInPage();
            loginpageObj.LoginSteps(driver);

        }

        [When(@"I add education on my profile\.")]
        public void WhenIAddEducationOnMyProfile_()
        {
            //Seller Education page Initialization and definition
            EducationPage EducationPageObj = new EducationPage();
            EducationPageObj.addEducation(driver);
        }

        [Then(@"The Education details should be added successfully\.")]
        public void ThenTheEducationDetailsShouldBeAddedSuccessfully_()
        {
            EducationPage EducationPageObj = new EducationPage();
            string CountryOfCollege = EducationPageObj.GetcountryOfCollege(driver);
            string UniversityNameTextBox = EducationPageObj.GetUniversityName(driver);
            string TitleDropDown = EducationPageObj.GetTitle(driver);
            string DegreeTextBox = EducationPageObj.GetDegreeTextBox(driver);
            string YearOfDegreeDropDown = EducationPageObj.GetYearOfDegree(driver);
            // Assertion
            Assert.That(CountryOfCollege == "India", "Actual Country and Expected Country do Not match");
            Assert.That(UniversityNameTextBox == "Andhra", "Actual University name and Expected  University name do Not match");
            Assert.That(TitleDropDown == "M.A", "Actual title and Expected  title do Not match");
            Assert.That(DegreeTextBox == "Economics", "Actual Degree and Expected  Degree do Not match");
            Assert.That(YearOfDegreeDropDown == "2006", "Actual Year and Expected  Year do Not match");
        }

        [When(@"I edited '([^']*)','([^']*)','([^']*)', '([^']*)', '([^']*)' on an existing education record\.\.")]
        public void WhenIEditedOnAnExistingEducationRecord_(string p0, string p1, string p2, string p3, string p4)
        {
            EducationPage EducationPageObj = new EducationPage();
            EducationPageObj.editEducation(driver, p0, p1, p2, p3, p4);
        }

        [Then(@"The record should have edited '([^']*)','([^']*)', '([^']*)', '([^']*)', '([^']*)' successfully\.")]
        public void ThenTheRecordShouldHaveEditedSuccessfully_(string p0, string p1, string p2, string p3, string p4)
        {
            EducationPage EducationPageObj = new EducationPage();
            string editcountryOfCollege = EducationPageObj.GetEditcountryOfCollege(driver);
            string editUniversityNameTextBox = EducationPageObj.GetEditUniversityName(driver);
            string editTitleDropDown = EducationPageObj.GetEditTitle(driver);
            string editDegreeTextBox = EducationPageObj.GetEditDegreeTextBox(driver);
            string editYearOfDegreeDropDown = EducationPageObj.GetEditYearOfDegreeDropDown(driver);
            // Assertion
            Assert.That(editcountryOfCollege == p0, "Actual edited Country and Expected edited Country do Not match");
            Assert.That(editUniversityNameTextBox == p1, "Actual edited University name and Expected edited University name do Not match");
            Assert.That(editTitleDropDown == p2, "Actual edited title and Expected edited title do Not match");
            Assert.That(editDegreeTextBox == p3, "Actual edited Degree and Expected edited Degree do Not match");
            Assert.That(editYearOfDegreeDropDown == p4, "Actual edited Year and Expected edited Year do Not match");
        }

        [When(@"I delete an education from an existing Education record")]
        public void WhenIDeleteAnEducationFromAnExistingEducationRecord()
        {
            EducationPage EducationPageObj = new EducationPage();
            EducationPageObj.deleteEducation(driver);
        }

        [Then(@"The education record should be deleted successfully\.")]
        public void ThenTheEducationRecordShouldBeDeletedSuccessfully_()
        {
            EducationPage EducationPageObj = new EducationPage();
            string deleteEducation = EducationPageObj.GetDeleteEducation(driver);
            Assert.That(deleteEducation != "United States", "Sellor record has not been deleted successfully.");
        }


        [When(@"I add certification on my profile\.")]
        public void WhenIAddCertificationOnMyProfile_()
        {
            CertificationsPage CertificationPageObj = new CertificationsPage();
            CertificationPageObj.addCertification(driver);
        }

        [Then(@"New Certificate details will be added\.")]
        public void ThenNewCertificateDetailsWillBeAdded_()
        {
            CertificationsPage CertificationPageObj = new CertificationsPage();
            string newCertification = CertificationPageObj.GetNewCertification(driver);
            string newCertifiedFrom = CertificationPageObj.GetNewCertifiedFrom(driver);
            string newYear = CertificationPageObj.GetNewYear(driver);
            // Assertion
            Assert.That(newCertification == "TestAnalyst", "Actual language and Expected language do Not match");
            Assert.That(newCertifiedFrom == "MVP", "Actual language level and Expected language level do Not match");
            Assert.That(newYear == "2022", "Actual language and Expected language do Not match");
        }

        [When(@"I edit '([^']*)', '([^']*)', '([^']*)'\.")]
        public void WhenIEdit_(string p0, string p1, string p2)
        {
            CertificationsPage CertificationPageObj = new CertificationsPage();
            CertificationPageObj.editCertification(driver, p0, p1, p2);
        }

        [Then(@"The Certificate should have edited '([^']*)','([^']*)', '([^']*)' updated\.")]
        public void ThenTheCertificateShouldHaveEditedUpdated_(string p0, string p1, string p2)
        {
            CertificationsPage CertificationPageObj = new CertificationsPage();
            string editCertificate = CertificationPageObj.GetEditCertificate(driver);
            string editCertifiedFrom = CertificationPageObj.GeteditCertifiedFrom(driver);
            string editCertifiedYear = CertificationPageObj.GeteditCertifiedYear(driver);
            // Assertion
            Assert.That(editCertificate == p0, "Actual edited Certificate and Expected edited Certificate do Not match");
            Assert.That(editCertifiedFrom == p1, "Actual edited Certificate and Expected edited Certificate do Not match");
            Assert.That(editCertifiedYear == p2, "Actual edited Certificate and Expected edited Certificate do Not match");
        }


        [When(@"I delete Certification from Certification record")]
        public void WhenIDeleteCertificationFromCertificationRecord()
        {
            CertificationsPage CertificationPageObj = new CertificationsPage();
            CertificationPageObj.deleteCertification(driver);
        }

        [Then(@"The Certification record should be deleted successfully")]
        public void ThenTheCertificationRecordShouldBeDeletedSuccessfully()
        {
            CertificationsPage CertificationPageObj = new CertificationsPage();
            string deleteCertification = CertificationPageObj.GetDeleteCertifications(driver);
            // Assertion
            Assert.That(deleteCertification != "Diploma", "Sellor record has not been deleted successfully.");
        }
    }
}
