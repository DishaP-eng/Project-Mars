using System;
using MarsQA1.Helper;
using MarsQA1.Specflow_Pages;
using TechTalk.SpecFlow;

namespace MarsQA1.Hooks
{
    [Binding]
    public class Hooks:Driver
    {
        Login_Page login = new Login_Page();
        Language_page languageObj = new Language_page();
        private static bool hasLoggedIn = false;
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            if (!hasLoggedIn)
            {
                Initialize();
                login.SingInAction();
                login.LogInAction();
                hasLoggedIn = true;
            }
        }

        [AfterScenario]
        public void Teardown()
        {
            if (hasLoggedIn)
            {
                languageObj.CloseSteps();
                hasLoggedIn = false;
            }
        }
    }
}