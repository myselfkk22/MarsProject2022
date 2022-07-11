
using MarsProject2022.Pages;
using MarsProject2022.Utilities;
using NUnit.Framework;


namespace MarsProject2022;
[TestFixture]
[Parallelizable]
public class Profile_Tests : CommonDriver
{
    [Test, Order(1)]
    public void addLanguage()
    {
        LanguagePage languagePageObj = new LanguagePage();
        languagePageObj.addLanguage(driver);
    }
    [Test, Order(2)]
    public void editLanguage()
    {
        LanguagePage languagePageObj = new LanguagePage();
        languagePageObj.editLanguage(driver, "dummy", "dummy1");
    }
    [Test, Order(3)]
    public void deleteLanguage()
    {
        LanguagePage languagePageObj = new LanguagePage();
        languagePageObj.deleteLanguage(driver);
    }



    [Test, Order(4)]
    public void addEducation()
    {

        EducationPage EducationPageObj = new EducationPage();
        EducationPageObj.addEducation(driver);
    }
    [Test, Order(5)]
    public void editEducation()
    {
        EducationPage EducationPageObj = new EducationPage();
        EducationPageObj.editEducation(driver, "dummy", "dummy1", "dummy2", "dummy3", "dummy4");
    }
    [Test, Order(6)]
    public void deleteEducation()
    {
        EducationPage EducationPageObj = new EducationPage();
        EducationPageObj.deleteEducation(driver);
    }




    [Test, Order(7)]
    public void AddCertifications()
    {
        CertificationsPage CertificationsPageObj = new CertificationsPage();
        CertificationsPageObj.addCertifications(driver);
    }
    [Test, Order(8)]
    public void editCertifications()
    {

        CertificationsPage CertificationsPageObj = new CertificationsPage();
        CertificationsPageObj.editCertifications(driver, "dummy", "dummy1", "dummy2");
    }
    [Test, Order(9)]
    public void deleteCertifications()
    {
        CertificationsPage CertificationsPageObj = new CertificationsPage();
        CertificationsPageObj.deleteCertifications(driver);
    }
}

