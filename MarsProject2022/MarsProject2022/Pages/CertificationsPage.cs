using MarsProject2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsProject2022.Pages
{
    public class CertificationsPage
    {
        public void addCertifications(IWebDriver driver)
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            //Identify certification Tab and click
            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();

            //Identify addnew button and click
            IWebElement certificationAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            certificationAddNewButton.Click();

            //Identify certificate or Award Text box and enter the value
            IWebElement certificateNameTextBox = driver.FindElement(By.Name("certificationName"));
            certificateNameTextBox.SendKeys("TestAnalyst");

            //Identify certified from Text box and enter the value
            IWebElement certifiedFromTextBox = driver.FindElement(By.Name("certificationFrom"));
            certifiedFromTextBox.SendKeys("MVP");

            //Choose Year from Year dropdown button and click
            IWebElement chooseCertificationYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
            chooseCertificationYear.Click();

            //Identify add button and click
            IWebElement certificationAddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            certificationAddButton.Click();

        }
        //Check if new Cirtification record created
        public string GetNewCertification(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]", 5);
            IWebElement newCertification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return newCertification.Text;
        }
        public string GetNewCertifiedFrom(IWebDriver driver)
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]", 5);
            IWebElement newCertifiedFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return newCertifiedFrom.Text;
        }
        public string GetNewYear(IWebDriver driver)
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]", 5);
            IWebElement newYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return newYear.Text;
        }


        public void editCertifications(IWebDriver driver, string Certificate, string CertifiedFrom, string Year)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            //Identify certification Tab and click
            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();

            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i", 5);
            //Identify edit write icon button and click
            IWebElement editCertificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
            editCertificationButton.Click();

            //Identify certificate or Award Text box and edit the value
            IWebElement certificateNameTextBox = driver.FindElement(By.Name("certificationName"));
            certificateNameTextBox.Clear();
            certificateNameTextBox.SendKeys(Certificate);

            //Identify certified from Text box and edit the value
            IWebElement certifiedFromTextBox = driver.FindElement(By.Name("certificationFrom"));
            certifiedFromTextBox.Clear();
            certifiedFromTextBox.SendKeys(CertifiedFrom);


            //Edit the certification year  dropdown list
            var editCertificationYear = driver.FindElement(By.Name("certificationYear"));
            var selectElement = new SelectElement(editCertificationYear);

            selectElement.SelectByValue(Year);


            //Identify update button and click
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]", 5);

            IWebElement certificationUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            certificationUpdateButton.Click();

        }
        //Check If the record edited
        public string GetEditCertificate(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]", 5);
            IWebElement editCertificate = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return editCertificate.Text;
        }
        public string GeteditCertifiedFrom(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]", 5);
            IWebElement editCertifiedFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return editCertifiedFrom.Text;
        }
        public string GeteditCertifiedYear(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]", 5);
            IWebElement editCertifiedYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return editCertifiedYear.Text;
        }


        public void deleteCertifications(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            //Identify certification Tab and click
            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();

            //Identify Certifications delete icon and click
            IWebElement deleteCertificationsIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
            deleteCertificationsIcon.Click();
        }
        //Identify certification Tab and click
        public string GetDeleteCertifications(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            return certificationButton.Text;
        }


    }
}
