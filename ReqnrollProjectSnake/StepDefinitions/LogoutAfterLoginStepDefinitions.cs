using System;
using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;
using Reqnroll;

namespace ReqnrollProjectSnake.StepDefinitions
{
    [Binding]
    public class LogoutAfterLoginStepDefinitions
    {
        [When("click on the logout button")]
        public void WhenClickOnTheLogoutButton()
        {
            NavigationHelper.Logout();
        }
    }
}
