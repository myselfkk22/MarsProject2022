using MarsProject2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject2022.Pages
{
    public class EducationPage
    {
        public void addEducation(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);

            //Identify Education Tab and click
            IWebElement educationTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();

            //Identify addnew button and click
            IWebElement educationAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            educationAddNewButton.Click();

            //Identify College/University Name Text box and enter the value
            IWebElement UniversityNameTextBox = driver.FindElement(By.Name("instituteName"));
            UniversityNameTextBox.SendKeys("Andhra");

            // Identify Country of college dropdown and select element
            IWebElement CountryOfCollegeDropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            CountryOfCollegeDropDown.Click();

            //Choose country from Country of college dropdown and click
            IWebElement chooseCountryOfCollege = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
            chooseCountryOfCollege.Click();

            //Identify Title dropdown and click
            IWebElement titleDropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropDown.Click();

            //Choose a Title from dropdown and click
            IWebElement chooseTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[9]"));
            chooseTitle.Click();

            //Identify Degree textbox and and enter the value
            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
            DegreeTextBox.SendKeys("Economics");

            //Identify Year of Graduation dropdown Button and click 
            IWebElement yearOfGraduationDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearOfGraduationDropdown.Click();

            //Choose Year from Year of Graduation dropdown button and click
            IWebElement chooseYearOfGraduation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[18]"));
            chooseYearOfGraduation.Click();

            //Identify add button and click
            IWebElement educationAddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            educationAddButton.Click();


        }
        //Assertions for edit Education
        public string GetcountryOfCollege(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]", 5);
            IWebElement CountryOfCollegeDropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return CountryOfCollegeDropDown.Text;
        }
        public string GetUniversityName(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]", 5);
            IWebElement UniversityNameTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return UniversityNameTextBox.Text;
        }
        public string GetTitle(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]", 5);
            IWebElement TitleDropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return TitleDropDown.Text;
        }
        public string GetDegreeTextBox(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]", 5);
            IWebElement DegreeTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return DegreeTextBox.Text;
        }
        public string GetYearOfDegree(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]", 5);
            IWebElement YearOfDegreeDropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return YearOfDegreeDropDown.Text;
        }

        public void editEducation(IWebDriver driver, string Country, string College, string Title, string Degree, string Year)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);

            //Identify Education Tab and click
            IWebElement educationTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();

            Thread.Sleep(3000);
            //Identify education edit write Icon and click
            IWebElement educationEditIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            educationEditIcon.Click();

            //Identify edit College/University Name Text box and edit the value
            IWebElement editUniversityNameTextBox = driver.FindElement(By.Name("instituteName"));
            editUniversityNameTextBox.Clear();
            editUniversityNameTextBox.SendKeys(College);

            //Edit the country dropdown list
            var editcountryOfCollege = driver.FindElement(By.Name("country"));
            var selectElement = new SelectElement(editcountryOfCollege);
            selectElement.SelectByValue(Country);


            //edit the Title dropdown list
            WaitHelpers.WaitToBeClickable(driver, "Name", "title", 5);
            var editTitleDropDown = driver.FindElement(By.Name("title"));
            var selectElement1 = new SelectElement(editTitleDropDown);
            selectElement1.SelectByValue(Title);


            //Identify Degree textbox and and edit the value
            IWebElement editDegreeTextBox = driver.FindElement(By.Name("degree"));
            editDegreeTextBox.Clear();
            editDegreeTextBox.SendKeys(Degree);

            //select the Year of Degree dropdown list
            var editYearOfDegreeDropDown = driver.FindElement(By.Name("yearOfGraduation"));
            var selectElement2 = new SelectElement(editYearOfDegreeDropDown);
            selectElement2.SelectByValue(Year);

            //Identify Education Update button and click
            IWebElement educationUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            educationUpdateButton.Click();


        }
        //Assertions for edit Education
        public string GetEditcountryOfCollege(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]", 5);
            IWebElement EditcountryOfCollege = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return EditcountryOfCollege.Text;
        }

        public string GetEditUniversityName(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]", 5);
            IWebElement editUniversityNameTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return editUniversityNameTextBox.Text;
        }

        public string GetEditTitle(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]", 5);
            IWebElement editTitleDropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return editTitleDropDown.Text;
        }
        public string GetEditDegreeTextBox(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]", 5);
            IWebElement editDegreeTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return editDegreeTextBox.Text;
        }
        public string GetEditYearOfDegreeDropDown(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]", 5);
            IWebElement editYearOfDegreeDropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return editYearOfDegreeDropDown.Text;
        }

        public void deleteEducation(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            //Identify Education Tab and click
            IWebElement educationTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i", 5);
            //Identify education delete icon and click
            IWebElement deleteEducationIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            deleteEducationIcon.Click();

        }
        public string GetDeleteEducation(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            //Identify Education Tab and click
            IWebElement educationTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            return educationTab.Text;


        }





    }



}

