using System;
using System.IO;
using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Log;
using Reqnroll;

namespace ReqnrollProjectSnake.StepDefinitions
{
    [Binding]
    public class SecurityStepDefinitions
    {
        [When("The user click on the security link")]
        public void WhenTheUserClickOnTheSecurityLink()
        {
            LinkHelper.ClickLink(By.LinkText("Set Security Level"));
        }

        [Then("verify the page is the security page")]
        public void ThenVerifyThePageIsTheSecurityPage()
        {
            Assert.AreEqual(PageHelper.GetPageTitle(), "bWAPP - Set Security Level");
        }

        [Then("the user select the security level")]
        public void ThenTheUserSelectTheSecurityLevel()
        {
            ComboBoxHelper.SelectElement(By.XPath("/html/body/div[2]/form/p/select"), "1");

        }

        [Then("the user click on the set button")]
        public void ThenTheUserClickOnTheSetButton()
        {
            ButtonHelper.ClickButton(By.Name("form"));  
        }

        [Then("Verify that the security level is set to the selected value")]
        public void ThenVerifyThatTheSecurityLevelIsSetToTheSelectedValue()
        {
            GenericHelper.IsElementPresentOnce(By.LinkText("Your security level is medium"));
        }

        [When("user select the security level")]
        public void WhenUserSelectTheSecurityLevel()
        {
            ComboBoxHelper.SelectElement(By.Name("security_level"), "0");
        }

        [When("the user click on the set button")]
        public void WhenTheUserClickOnTheSetButton()
        {
            GenericHelper.IsElementPresentOnce(By.LinkText("Current: low"));
        }
    }
}
