Feature: PasswordChange
Test des differents scenarios de changement de mot de passe

 Background:
	Given On login page  
	When The credentials imputs are filled with good login and password
	And button login is clicked
	Then verify the page is the portal page
	And click on the menu link Change Password


Scenario: Change password with good credentials 
	Then fill the form with good credentials
	And click on the button change
	Then verify the password is changed in the change page

Scenario: Change password with wrong current password
	Then fill the form with wrong current password
	And click on the button change
	Then verify the error message is displayed for current password

Scenario: Change password with wrong new password match
	Then fill the form with wrong password match
	And click on the button change
	Then verify the error message is displayed for new password match

Scenario: Change password with no new password
	When click on the button change
	Then verify the error message is displayed for no password


Scenario: Change password with good credentials and try to login with good new credentials
	Then fill the form with good credentials
	And click on the button change
	Then verify the password is changed in the change page
	When click on the logout button
	Then verify the page is the login page
	And fill the form with new good credentials
	And button login is clicked
	Then verify the page is the portal page



