using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarsQA1.Helper;
using MarsQA1.Specflow_Pages;
using TechTalk.SpecFlow;

namespace MarsQA1.Steps;

[Binding]
public sealed class Language_Steps:Driver
{ 
    Language_page languageObj = new Language_page();
    
    [Given(@"I click on Add new language\.")]
    public void GivenIClickOnAddNewLanguage()
    {
        
        languageObj.LanguageTab(driver);
    }
    
    [When(@"I Enter '(.*)' and '(.*)'")]
    public void WhenIEnterAnd(string p0, string p1)
    {
        languageObj.AddNew(driver,p0,p1);
        
    }
    [When(@"Click on Add Button\.")]
    public void WhenClickOnAddButton()
    {
       languageObj.ClickAddButton();
    }
    
    
    [Then(@"I should see a validation message '(.*)'")]
    public void ThenIShouldSeeAValidationMessage(string p0)
    {
       languageObj.Add_Verify(driver,p0);
    }


    [Given(@"I click on Edit icon")]
    public void GivenIClickOnEditIcon()
    {
       languageObj.ClickEditIcon(driver);
    }

    [When(@"I Edit '(.*)' and '(.*)")]
    public void WhenIEditAnd(string p0, string p1)
    {
        languageObj.EditLanguage(driver,p0,p1);
    }

    [When(@"I click on Update button")]
    public void WhenIClickOnUpdateButton()
    {
       languageObj.ClickUpdateButton(driver);
    }

    [Then(@"I should see a Update validation message '(.*)'")]
    public void ThenIShouldSeeAUpdateValidationMessage(string p0)
    {
        languageObj.Edit_Verify(driver,p0);
    }

    [When(@"I click on Delete icon")]
    public void WhenIClickOnDeleteIcon()
    {
        languageObj.DeleteLanguage();
    }
    
    [Then(@"I should see a Delete validation message '(.*)'")]
    public void ThenIShouldSeeADeleteValidationMessage(string p0)
    {
        languageObj.Delete_Verify(driver,p0);
    }

    [When(@"I click on Cancel Button\.")]
    public void WhenIClickOnCancelButton()
    {
        languageObj.CancelButton(driver);
    }
    [Given(@"I Click on Language tab")]
    public void GivenIClickOnLanguageTab()
    {
        languageObj.LanguageTab(driver);
    } 

    [Then(@"The name of the tab should be ""(.*)""")]
    public void ThenTheNameOfTheTabShouldBe(string language)
    {
        languageObj.TabNameCheck(driver);
    }
}
