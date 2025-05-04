using System;
using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;
using Reqnroll;

namespace ReqnrollProjectSnake.StepDefinitions
{
    [Binding]
    public class PasswordChangeStepDefinitions
    {
        [Then("click on the menu link Change Password")]
        public void ThenClickOnTheMenuLinkChangePassword()
        {
            LinkHelper.ClickLink(By.LinkText("Change Password"));
        }

        [Then("fill the form with good credentials")]
        public void ThenFillTheFormWithGoodCredentials()
        {
            TextBoxHelper.TypeInTextBox(By.Id("password_curr"), "bug");
            TextBoxHelper.TypeInTextBox(By.Id("password_new"), "bug");
            TextBoxHelper.TypeInTextBox(By.Id("password_conf"), "bug");
        }

        [Then("click on the button change")]
        public void ThenClickOnTheButtonChange()
        {
            ButtonHelper.ClickButton(By.Name("action"));
        }

        [Then("verify the password is changed in the change page")]
        public void ThenVerifyThePasswordIsChangedInTheChangePage()
        {
            GenericHelper.IsElementPresentOnce(By.LinkText("The password has been changed!"));
        }

        [Then("fill the form with wrong current password")]
        public void ThenFillTheFormWithWrongCurrentPassword()
        {
            TextBoxHelper.TypeInTextBox(By.Id("password_curr"), "wrongPassword");
            TextBoxHelper.TypeInTextBox(By.Id("password_new"), "bug");
            TextBoxHelper.TypeInTextBox(By.Id("password_conf"), "bug");
        }

        [Then("verify the error message is displayed for current password")]
        public void ThenVerifyTheErrorMessageIsDisplayedForCurrentPassword()
        {
            GenericHelper.IsElementPresentOnce(By.LinkText("The current password is not valid!"));
        }

        [Then("fill the form with wrong password match")]
        public void ThenFillTheFormWithWrongPasswordMatch()
        {

            TextBoxHelper.TypeInTextBox(By.Id("password_curr"), "bug");
            TextBoxHelper.TypeInTextBox(By.Id("password_new"), "bug");
            TextBoxHelper.TypeInTextBox(By.Id("password_conf"), "wrongMatch");
        }

        [Then("verify the error message is displayed for new password match")]
        public void ThenVerifyTheErrorMessageIsDisplayedForNewPasswordMatch()
        {
            GenericHelper.IsElementPresentOnce(By.LinkText("The passwords don't match!"));
        }

        [When("click on the button change")]
        public void WhenClickOnTheButtonChange()
        {
            ButtonHelper.ClickButton(By.Name("action"));
        }

        [Then("verify the error message is displayed for no password")]
        public void ThenVerifyTheErrorMessageIsDisplayedForNoPassword()
        {
            GenericHelper.IsElementPresentOnce(By.LinkText("Please enter a new password..."));
        }

        [Then("fill the form with new good credentials")]
        public void ThenFillTheFormWithNewGoodCredentials()
        {
            Thread.Sleep(1000);
            TextBoxHelper.TypeInTextBox(By.Id("login"), "bee");
            TextBoxHelper.TypeInTextBox(By.Id("password"), "bug");
        }

        [Then("button login is clicked")]
        public void ThenButtonLoginIsClicked()
        {
            ButtonHelper.ClickButton(By.Name("form"));
            Thread.Sleep(1000);
        }
    }
}
