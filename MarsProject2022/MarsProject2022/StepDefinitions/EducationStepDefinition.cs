using MarsProject2022.Pages;
using MarsProject2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsProject2022.StepDefinitions
{
    [Binding]
    public class EducationStepDefinition :CommonDriver
    {
        [After]
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }
        //Education

        [Given(@"I signin into the Mars portal\.")]
        public void GivenISigninIntoTheMarsPortal_()
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

    }
}
