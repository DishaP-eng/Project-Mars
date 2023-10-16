using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarsQA1.Helper;
using MarsQA1.Specflow_Pages;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsQA1.Steps;

[Binding]
public sealed class Login_Step:Driver
{
    Login_Page login = new Login_Page();
    
    [When(@"I click on Login button")]
    public void WhenIClickOnLoginButton()
    {
        Initialize();
        login.SingInAction();
        //ExelLibHelper.PopulateInCollection(ConstantHelpers.MarsDataPath, "Credentials");
    }

    [Then(@"I should able to login successfully using valid credential")]
    public void ThenIShouldAbleToLoginSuccessfullyUsingValidCredential()
    {
        login.LogInAction();
    }
}