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
    public class LanguagePage
    {
        public void addLanguage(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);
            //Identify language Tab and click
            IWebElement languageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageButton.Click();

            //Identify language addnew button and click
            IWebElement languageAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            languageAddNewButton.Click();

            //Identify language name Text box and enter the value
            IWebElement addLanguageTextBox = driver.FindElement(By.Name("name"));
            addLanguageTextBox.SendKeys("English");

            // Identify language level dropdown and click
            IWebElement languageLevelDropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevelDropDown.Click();

            //Choose level from language level  dropdown and click
            IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            chooseLanguageLevel.Click();

            //Identify add button and click
            IWebElement languageAddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            languageAddButton.Click();

        }
        public string GetNewLanguage(IWebDriver driver)
        {
            //Check if new language record created
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 5);
            IWebElement newLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newLanguage.Text;
        }
        public string GetNewLanguageLevel(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]", 5);
            IWebElement newLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return newLanguageLevel.Text;
        }


        public void editLanguage(IWebDriver driver, string Language, string LanguageLevel)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 6);
            //Identify language Tab and click
            IWebElement languageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageButton.Click();

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 5);
            //Identify language edit write icon and click
            IWebElement languageEditWriteIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            languageEditWriteIcon.Click();

            //Identify language name Text box and edit the value
            IWebElement editLanguageTextBox = driver.FindElement(By.Name("name"));
            editLanguageTextBox.Clear();
            editLanguageTextBox.SendKeys(Language);

            //select the language level dropdown list
            var languageLevel = driver.FindElement(By.Name("level"));
            var selectElement = new SelectElement(languageLevel);

            selectElement.SelectByValue(LanguageLevel);

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 5);

            //Identify language Update button and click
            IWebElement languageUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            languageUpdateButton.Click();



        }

        public string GetEditNewLanguage(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 5);
            //Check if new language record created
            IWebElement editNewLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return editNewLanguage.Text;
        }
        public string GetEditNewLanguageLevel(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]", 5);
            IWebElement editNewLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return editNewLanguageLevel.Text;

        }


        public void deleteLanguage(IWebDriver driver)
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);
            //Identify editedlanguage and click
            IWebElement editedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            editedLanguage.Click();

            //Identify language delete icon and click
            IWebElement deleteLanguageIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteLanguageIcon.Click();

        }
        public string GetDeleteLanguageIcon(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);
            //Identify editedlanguage and click
            IWebElement editedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            return editedLanguage.Text;

        }
    }
}
