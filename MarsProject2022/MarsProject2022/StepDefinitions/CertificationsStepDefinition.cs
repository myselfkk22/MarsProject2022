using MarsProject2022.Pages;
using MarsProject2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsProject2022.StepDefinitions
{
    [Binding]
    public class CertificationsStepDefinition :CommonDriver
    {
        [After]
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }
        [Given(@"I login into the Mars portal\.")]
        public void GivenILoggedIntoTheMarsPortal_()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //login page object initialization and definition
            LogInPage loginpageObj = new LogInPage();
            loginpageObj.LoginSteps(driver);

        }

        [When(@"I add certification on my profile\.")]
        public void WhenIAddCertificationOnMyProfile_()
        {
            CertificationsPage CertificationsPageObj = new CertificationsPage();
            CertificationsPageObj.addCertifications(driver);
        }

        [Then(@"New Certificate details will be added\.")]
        public void ThenNewCertificateDetailsWillBeAdded_()
        {
            CertificationsPage CertificationsPageObj = new CertificationsPage();
            string newCertification = CertificationsPageObj.GetNewCertification(driver);
            string newCertifiedFrom = CertificationsPageObj.GetNewCertifiedFrom(driver);
            string newYear = CertificationsPageObj.GetNewYear(driver);
            // Assertion
            Assert.That(newCertification == "TestAnalyst", "Actual language and Expected language do Not match");
            Assert.That(newCertifiedFrom == "MVP", "Actual language level and Expected language level do Not match");
            Assert.That(newYear == "2022", "Actual language and Expected language do Not match");
        }

        [When(@"I edit '([^']*)', '([^']*)', '([^']*)'\.")]
        public void WhenIEdit_(string p0, string p1, string p2)
        {
            CertificationsPage CertificationsPageObj = new CertificationsPage();
            CertificationsPageObj.editCertifications(driver, p0, p1, p2);
        }

        [Then(@"The Certificate should have edited '([^']*)','([^']*)', '([^']*)' \.")]
        public void ThenTheCertificateShouldHaveEdited_(string p0, string p1, string p2)
        {

            CertificationsPage CertificationsPageObj = new CertificationsPage();
            string editCertificate = CertificationsPageObj.GetEditCertificate(driver);
            string editCertifiedFrom = CertificationsPageObj.GeteditCertifiedFrom(driver);
            string editCertifiedYear = CertificationsPageObj.GeteditCertifiedYear(driver);
            // Assertion
            Assert.That(editCertificate == p0, "Actual edited Certificate and Expected edited Certificate do Not match");
            Assert.That(editCertifiedFrom == p1, "Actual edited Certificate and Expected edited Certificate do Not match");
            Assert.That(editCertifiedYear == p2, "Actual edited Certificate and Expected edited Certificate do Not match");
        }



        [When(@"I delete Certification from Certification record")]
        public void WhenIDeleteCertificationFromCertificationRecord()
        {
            CertificationsPage CertificationsPageObj = new CertificationsPage();
            CertificationsPageObj.deleteCertifications(driver);
        }

        [Then(@"The Certification record should be deleted successfully")]
        public void ThenTheCertificationRecordShouldBeDeletedSuccessfully()
        {
            CertificationsPage CertificationsPageObj = new CertificationsPage();
            string deleteCertifications = CertificationsPageObj.GetDeleteCertifications(driver);
            // Assertion
            Assert.That(deleteCertifications != "Diploma", "Sellor record has not been deleted successfully.");
        }
    }
}
