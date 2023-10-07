using System;
using MarsQA1.Helper;
using OpenQA.Selenium;

namespace MarsQA1.Specflow_Pages.Components;

public class ProfileLanguageTabComponents
{
    public IWebElement languageTab;
    public IWebElement addLanguageButton;
    public IWebElement inputLanguageTextBox;
    public IWebElement chooseLanguageDropdown;
    public IWebElement addButton;
    public IWebElement cancelButton;

    public void renderComponents()
    {
        try
        {
            languageTab = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            addLanguageButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")); 
            inputLanguageTextBox = Driver.driver.FindElement(By.Name("name"));
            chooseLanguageDropdown = Driver.driver.FindElement(By.Name("level"));
            addButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            cancelButton = Driver.driver.FindElement(By.XPath(""));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}