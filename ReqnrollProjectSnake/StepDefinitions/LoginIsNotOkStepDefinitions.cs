using System;
using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;
using Reqnroll;

namespace ReqnrollProjectSnake.StepDefinitions
{
    [Binding]
    public class LoginIsNotOkStepDefinitions
    {
        [When("The credentials imputs are filled with wrong login and password")]
        public void WhenTheCredentialsImputsAreFilledWithWrongLoginAndPassword()
        {
            TextBoxHelper.TypeInTextBox(By.Id("login"), "Ahah");
            TextBoxHelper.TypeInTextBox(By.Id("password"), "Falsepassword");
        }

        [Then("verify the page is the login page")]
        public void ThenVerifyThePageIsTheLoginPage()
        {
            GenericHelper.IsElementPresentOnce(By.LinkText("Invalid credentials or user not activated!"));
        }
    }
}
