using System;
using MarsQA1.Helper;
using OpenQA.Selenium;

namespace MarsQA1.Specflow_Pages.Components;

public class LanguageTabComponent
{
    public IWebElement languageTab;
    public IWebElement addNewButton;
    // public IWebElement languageTextBox;
   // public IWebElement languageDropdown;
    public IWebElement addButton;
    
    public string e_languageTab;
    public string e_addNewButton;
    //public string e_languageTextBox;
    public string e_addButton;

    public void renderComponent()
    {
     
      //Finding Elements for profile page 
      languageTab =
       Driver.driver.FindElement(
        By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
      addNewButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                                                        "/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
      // languageTextBox = Driver.driver.FindElement(By.Name("name"));
      //languageDropdown=Driver.driver.FindElement(By.Name("level"));

      addButton = Driver.driver.FindElement(By.XPath(
       "//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));



      //Finding Element for wait
      e_languageTab = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]";
      e_addNewButton = "//*[@id='account-profile-section']/div" +
                       "/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div";
      //  e_languageTextBox = "name";
        e_addButton = "//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]";
     }
    
}
