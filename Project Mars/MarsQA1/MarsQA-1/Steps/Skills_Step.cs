using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using MarsQA1.Helper;
using MarsQA1.Specflow_Pages;
using TechTalk.SpecFlow;

namespace MarsQA1.Steps;

[Binding]
public sealed class Skills_Step : Driver
{
    Skill_Page skillsObj = new Skill_Page();
    
    [Given(@"I click on Add new Skill")]
    public void GivenIClickOnAddNewSkill()
    {
       skillsObj.SkillTab(driver);
    }

    [When(@"I Enter '(.*)' and '(.*)' in skill feature")]
    public void WhenIEnterAndInSkillFeature(string p0, string p1)
    {
       skillsObj.AddNewSkill(driver,p0,p1);
    }

    [When(@"I Click on Add Button of Skill feature")]
    public void WhenIClickOnAddButtonOfSkillFeature()
    {
        skillsObj.ClickAddButton();
    }

    [Then(@"I should see a Skill Validation message '(.*)'")]
    public void ThenIShouldSeeASkillValidationMessage(string p0)
    {
        skillsObj.SkillAdd_Verify(driver,p0);
    }


    [Given(@"I click on Edit icon for skill")]
    public void GivenIClickOnEditIconForSkill()
    {
        skillsObj.ClickEditIconSkill(driver);
    }

    [When(@"I Update '(.*)' and '(.*) in skill feature")]
    public void WhenIUpdateAndInSkillFeature(string p0, string p1)
    {
        skillsObj.EditSkill(driver,p0,p1);
    }


    [When(@"I click on Update button for skill")]
    public void WhenIClickOnUpdateButtonForSkill()
    {
        skillsObj.ClickUpdateButton();
    }

    [Then(@"I should see a Skill Update validation message '(.*)'")]
    public void ThenIShouldSeeASkillUpdateValidationMessage(string p0)
    {
        skillsObj.SkillEditVerify(driver,p0);
    }

    [When(@"I click on Delete icon for Skill")]
    public void WhenIClickOnDeleteIconForSkill()
    {
      skillsObj.ClickDeleteSkill();
    }

    [Then(@"I should see a Skill Delete validation message '(.*)'")]
    public void ThenIShouldSeeASkillDeleteValidationMessage(string p0)
    {
        skillsObj.SkillDeleteVerify(driver,p0);
    }

    [When(@"I click on Cancel Button")]
    public void WhenIClickOnCancelButton()
    {
        skillsObj.CancelButton(driver);
    }

    [Given(@"I Click on Skill tab")]
    public void GivenIClickOnSkillTab()
    {
        skillsObj.SkillTab(driver);
    }

    [Then(@"The name of the tab should be ""(.*)""\.")]
    public void ThenTheNameOfTheTabShouldBe(string skill)
    {
        skillsObj.TabNameCheck(driver);
    }
}