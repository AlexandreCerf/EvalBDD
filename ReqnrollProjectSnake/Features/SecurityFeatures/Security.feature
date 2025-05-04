Feature: Security

Modifier le niveau de securite apres la connection

 Background:
	Given On login page  
	When The credentials imputs are filled with good login and password
	And button login is clicked
	Then verify the page is the portal page

@tag1
Scenario: Change the security level in the click link
	When The user click on the security link 
	Then verify the page is the security page
	Then the user select the security level 
	And the user click on the set button
	Then Verify that the security level is set to the selected value


Scenario: Change the security level in the portal page
	When user select the security level 
	And the user click on the set button
	Then Verify that the security level is set to the selected value




