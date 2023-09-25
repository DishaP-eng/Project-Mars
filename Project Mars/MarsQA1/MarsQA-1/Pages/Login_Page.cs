using System.Threading;
using MarsQA1.Helper;
using OpenQA.Selenium;
//using Driver = MarsQA1.Helper.Driver;


namespace MarsQA1.Specflow_Pages;

public class Login_Page
{
    public string username { get; private set; }


    public void SingInAction(IWebDriver driver)
    {
        driver.Navigate().GoToUrl("http://localhost:8080/");
        //Cilck on Sing In Button
        
        Thread.Sleep(2000);
        IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
        signInButton.Click();
        Thread.Sleep(2000);
    }

    public void LogInAction(IWebDriver driver)
    {
        //Enter Email address
        IWebElement emailAddressTextBox = driver.FindElement(By.Name("email"));
        emailAddressTextBox.SendKeys(ExelLibHelper.ReadData(2, "username"));
       // emailAddressTextBox.SendKeys("dmpandya011@gmail.com");
        
        //Enter Password
        Thread.Sleep(2000);
        IWebElement passwordTextBox = driver.FindElement(By.Name("password"));
        passwordTextBox.SendKeys(ExelLibHelper.ReadData(2, "password"));
       // passwordTextBox.SendKeys("Dwija@0111");
        
        
        //Click on Remember me checkbox
        Thread.Sleep(2000);
        IWebElement rememberMeCheckBox = driver.FindElement(By.Name("rememberDetails"));
        rememberMeCheckBox.Click();
        
        //Click on Login Button
        Thread.Sleep(2000);
        IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        LoginButton.Click();
        


    }
}