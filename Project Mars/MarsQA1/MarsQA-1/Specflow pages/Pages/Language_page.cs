using System;
using System.Threading;
using Gherkin.CucumberMessages.Types;
using MarsQA1.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MarsQA1.Specflow_Pages;

public class Language_page
{
    
    public void LanguageTab(IWebDriver driver)
    {
        Wait.WaitToBeClickable(driver, "XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div" , 3); 
        Driver.driver.FindElement(By.XPath(
            "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
    }

    public void AddNew(IWebDriver driver,string language, string dropdownValue)
    {
        //Enter the language in the TextBox
        Driver.driver.FindElement(By.Name("name")).SendKeys(language);
        
       //Find the Dropdown Element
        Wait.WaitToBeClickable(driver, "Name", "level", 5);
        IWebElement dropdown = Driver.driver.FindElement(By.Name("level"));
        SelectElement select = new SelectElement(dropdown);
        select.SelectByText(dropdownValue);
        
    }

    public void ClickAddButton()
    {
        Driver.driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
    }

    public void Add_Verify(IWebDriver driver,string validationMessage)
    {
       try
       {
           Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 5);
           IWebElement toastElement = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

           var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
           switch (scenarioTitle)
           {
               case "Scenario1":
                   Assert.AreEqual("English has been added to your languages",toastElement.Text);
                   break;
               case "Scenario2":
                   Assert.AreEqual("Please enter language and level",toastElement.Text);
                   break;
               case "Scenario3":
                   Assert.AreEqual("Please enter language and level",toastElement.Text);
                   break;
               case "Scenario4":
                   Assert.AreEqual("This language is already exist in your language list",toastElement.Text);
                   break;
               case "Scenario5":
                   Assert.AreEqual("This is for test This is for test added to your languages",toastElement.Text);
                   break;
           }
       }
       catch (Exception e)
       {
           Console.WriteLine("Exception occurred:" + e.Message);
           throw;
       }
    }
        
    public void ClickEditIcon(IWebDriver driver)
    {
        Wait.WaitToBeClickable(driver, "XPath","//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i" , 3);
        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();
        Thread.Sleep(2000);
    }

    public void EditLanguage(IWebDriver driver,string language, string dropdownValue)
    {
        //language click
        Driver.driver
            .FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"))
            .Click();

        //language clear
        Driver.driver
            .FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"))
            .Clear();

        //Add new value in language TextBox
        Driver.driver
            .FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"))
            .SendKeys(language);

        //Select Dropdown 
        Wait.WaitToBeClickable(driver, "Name", "level", 3);
        IWebElement dropdown = Driver.driver.FindElement(By.Name("level"));

        SelectElement select = new SelectElement(dropdown);
        select.SelectByText(dropdownValue);
        
    }
    public void ClickUpdateButton(IWebDriver driver)
    { 
        Thread.Sleep(2000);
        //Wait.WaitToBeClickable(driver, "XPath"," \"//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 10);
        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        Thread.Sleep(2000);
    }

    public void Edit_Verify(IWebDriver driver,string validationMessage)
    {
        try
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            IWebElement toastElement = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            switch (scenarioTitle)
            {
                case "Scenario1":
                    Assert.AreEqual("Spanish has been updated to your languages",toastElement.Text);
                    break;
                case "Scenario2":
                    Assert.AreEqual("Please enter language and level",toastElement.Text);
                    break;
                case "Scenario3":
                    Assert.AreEqual("Please enter language and level",toastElement.Text);
                    break;
                case "Scenario4":
                    Assert.AreEqual("This language is already exist in your language list",toastElement.Text);
                    break;
                case "Scenario5":
                    Assert.AreEqual("This is for test This is for test added to your languages",toastElement.Text);
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception occurred:" + e.Message);
            throw;
        }
    }

    public void DeleteLanguage()
        {
            //Click on Remove icon
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();
        }

    public void Delete_Verify(IWebDriver driver,string validationMessage)
    {
        try
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            IWebElement toastElement = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            switch (scenarioTitle)
            {
                case "Scenario1":
                    Assert.AreEqual("Spanish has been deleted from your languages", toastElement.Text);
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception occurred:" + e.Message);
            throw;
        }
    }
    public void CancelButton(IWebDriver driver)
    {
        Wait.WaitToBeClickable(driver, "XPath","//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]" , 3);
        Driver.driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]")).Click();
    }

    public void TabNameCheck(IWebDriver driver)
    {
        IWebElement tabElement = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        string tabName = tabElement.Text;
        string expectedTabName = "Languages";
        Assert.AreEqual(expectedTabName,tabName,$"Expected tab name:{expectedTabName},Actual tab name:{tabName}");
    }
    
    public void CloseSteps()
    {
        Driver.driver.Quit();
    }
}