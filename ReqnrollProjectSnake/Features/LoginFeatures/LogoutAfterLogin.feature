Feature: LogoutAfterLogin

Apres s'etre log l'utilisateur doit pouvoir se déconnecter


 Background:
	Given On login page  
	When The credentials imputs are filled with good login and password
	And button login is clicked
	Then verify the page is the portal page

@tag1
Scenario: user can logout
	When click on the logout button
	Then verify the page is the login page
