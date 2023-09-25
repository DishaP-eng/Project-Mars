using System;
using System.Threading;
using MarsQA1.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MarsQA1.Specflow_Pages;

public class Skill_Page
{
    public void SkillTab(IWebDriver driver)
    {
        //click on Skill tab
        Driver.driver
            .FindElement(
                By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();

        //click on Add new skill
        Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 3);
        Driver.driver
            .FindElement(By.XPath(
               "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
        
    }
    public void AddNewSkill(IWebDriver driver,string skill, string dropdownValue)
    {
        //Enter the skill in the Textbox
        Driver.driver.FindElement(By.Name("name")).SendKeys(skill);
        Wait.WaitToBeClickable(driver, "Name", "level", 3);
        
        //Select the dropdown
        IWebElement dropdown = Driver.driver.FindElement(By.Name("level"));

        SelectElement select = new SelectElement(dropdown);
        select.SelectByText(dropdownValue);
    }
    public void ClickAddButton()
    {

        //Click on Add button
        Driver.driver
            .FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"))
            .Click();
        Thread.Sleep(2000);
    }
    public void SkillAdd_Verify(IWebDriver driver, string validationMessage)
    {
        try
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            IWebElement toastElement = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            switch (scenarioTitle)
            {
                case "Scenario1":
                    Assert.AreEqual("Math has been added to your skills", toastElement.Text);
                    break;
                case "Scenario2":
                    Assert.AreEqual("Please enter skill and level", toastElement.Text);
                    break;
                case "Scenario3":
                    Assert.AreEqual("Please enter skill and level", toastElement.Text);
                    break;
                case "Scenario4":
                    Assert.AreEqual("This skill is already exist in your skill list", toastElement.Text);
                    break;
                case "Scenario5":
                    Assert.AreEqual("This is for test This is for test added to your skills", toastElement.Text);
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception occurred:" + e.Message);
            throw;
        }
    }
    public void ClickEditIconSkill(IWebDriver driver)
    {
        //click on Skill tab
        Driver.driver
            .FindElement(
                By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        //Click on Edit icon
        Wait.WaitToBeClickable(driver, "XPath","//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i" , 10);
        Driver.driver
            .FindElement(By.XPath(
              "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"))
            .Click();
    }
    public void EditSkill(IWebDriver driver,string skill,string dropdownValue)
    {
        //Click on Skill Textbox
        Thread.Sleep(2000);
        Driver.driver.FindElement(By.Name("name")).Click();
        Thread.Sleep(2000);
        Driver.driver.FindElement(By.Name("name")).Clear();
        Thread.Sleep(2000);
        Driver.driver.FindElement(By.Name("name")).SendKeys(skill);
        
        //Select the dropdown
        Wait.WaitToBeClickable(driver, "Name", "level", 5);
        IWebElement dropdown = Driver.driver.FindElement(By.Name("level"));

        SelectElement select = new SelectElement(dropdown);
        select.SelectByText(dropdownValue);
    }
    public void ClickUpdateButton()
        {
            Thread.Sleep(2000);
            //Click on update
            Driver.driver
                .FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]")).Click();
            Thread.Sleep(2000);
        }
    public void SkillEditVerify(IWebDriver driver,string validationMessage)
    {
        try
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            IWebElement toastElement = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            switch (scenarioTitle)
            {
                case "Scenario1":
                    Assert.AreEqual("Science has been updated to your Skills",toastElement.Text);
                    break;
                case "Scenario2":
                    Assert.AreEqual("This skill is already exist in your skill list",toastElement.Text);
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception occurred:" + e.Message);
            throw;
        }
    }

    public void ClickDeleteSkill()
    {
        //click on Skill tab
        Driver.driver
            .FindElement(
                By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        
        //Click on Remove icon
        Driver.driver
            .FindElement(By.XPath(
               "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i")).Click();
    }

    public void SkillDeleteVerify(IWebDriver driver, string validationMessage)
    {
        try
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            IWebElement toastElement = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            switch (scenarioTitle)
            {
                case "Scenario1":
                    Assert.AreEqual("Science has been deleted from your Skill", toastElement.Text);
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
