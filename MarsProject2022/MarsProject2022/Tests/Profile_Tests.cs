
using MarsProject2022.Pages;
using MarsProject2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    public void AddCertification()
    {
        CertificationsPage CertificationsPageObj = new CertificationsPage();
        CertificationsPageObj.addCertification(driver);
    }
    [Test, Order(8)]
    public void editCertifications()
    {

        CertificationsPage CertificationsPageObj = new CertificationsPage();
        CertificationsPageObj.editCertification(driver, "dummy", "dummy1", "dummy2");
    }
    [Test, Order(9)]
    public void deleteCertifications()
    {
        CertificationsPage CertificationsPageObj = new CertificationsPage();
        CertificationsPageObj.deleteCertification(driver);
    }
}
