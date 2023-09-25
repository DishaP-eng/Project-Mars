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
        //click on Language tab
        Thread.Sleep(2000);
       
        Driver.driver.FindElement(
                By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
       
        //click on Add new Language
         Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 5);
         Driver.driver.FindElement(By.XPath(
            "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
    }

    public void AddNew(IWebDriver driver,string language, string dropdownValue)
    {
        //Enter the language in the textbox
        Driver.driver.FindElement(By.Name("name")).SendKeys(language);
        Wait.WaitToBeClickable(driver, "Name", "level", 5);
        //Find the dropdown element
        IWebElement dropdown = Driver.driver.FindElement(By.Name("level"));

        SelectElement select = new SelectElement(dropdown);
        select.SelectByText(dropdownValue);
    }

    public void ClickAddButton()
    {
        //Click on Add button
        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
        Thread.Sleep(2000);

    }

    public void Add_Verify(IWebDriver driver,string validationMessage)
    {
       try
       {
           Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 30);
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
    }// /html/body/div[1]/div
    // /html/body/div[1]/div
        
    public void ClickEditIcon(IWebDriver driver)
    {
        //Click on Edit icon
        Wait.WaitToBeClickable(driver, "XPath","//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i" , 3);
        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();
        //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i
    }

    public void EditLanguage(string language, string dropdownValue)
    {
        //language click
        Driver.driver
            .FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"))
            .Click();

        //language clear
        Thread.Sleep(2000);
        Driver.driver
            .FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"))
            .Clear();

        //Add new value in language Textbox
        Thread.Sleep(2000);
        Driver.driver
            .FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"))
            .SendKeys(language);

        //Select Dropdown 
        IWebElement dropdown = Driver.driver.FindElement(By.Name("level"));

        SelectElement select = new SelectElement(dropdown);
        select.SelectByText(dropdownValue);
    }
    public void ClickUpdateButton()
    {
    //Click on update
        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        
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
                    Assert.AreEqual("This language is already exist in your language list",toastElement.Text);
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
        /*
        IWebElement English = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));

        if (English.Text != "English")
        {
            Assert.Pass("Language has been deleted successfully");
            
        }
        else
        {
            Assert.Fail("Language has not been deleted");
        }
        */
        try
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            IWebElement toastElement = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            switch (scenarioTitle)
            {
                case "Scenario1":
                    Assert.AreEqual("Spanish has been deleted from your languages",toastElement.Text);
                    break;
                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception occurred:" + e.Message);
            throw;
        }
        
    }
    public void CloseSteps()
    {
        Driver.driver.Quit();
    }
}