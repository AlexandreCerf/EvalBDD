using System;
using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;
using Reqnroll;

namespace ReqnrollProjectSnake.StepDefinitions
{
    [Binding]
    public class LoginIsOkStepDefinitions
    {
        [Given("On login page")]
        public void GivenOnLoginPage()
        {
            NavigationHelper.NavigateToHomePage();

            Assert.AreEqual(PageHelper.GetPageTitle(), "bWAPP - Login");
        }

        [When("The credentials imputs are filled with good login and password")]
        public void WhenTheCredentialsImputsAreFilledWithGoodLoginAndPassword()
        {
            TextBoxHelper.TypeInTextBox(By.Id("login"), "bee");
            TextBoxHelper.TypeInTextBox(By.Id("password"), "bug");
        }

        [When("button login is clicked")]
        public void WhenButtonLoginIsClicked()
        {
            ButtonHelper.ClickButton(By.Name("form"));
            Thread.Sleep(1000);
        }

        [Then("verify the page is the portal page")]
        public void ThenVerifyThePageIsThePortalPage()
        {
            Assert.AreEqual(PageHelper.GetPageTitle(), "bWAPP - Portal");
        }
    }
}