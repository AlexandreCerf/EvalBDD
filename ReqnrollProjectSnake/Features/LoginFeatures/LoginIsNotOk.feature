Feature: LoginIsNotOk

Sur la page de login entrer un faux login et le mot de passe et s'assurer que l'on est toujours sur la page login

@tag1
Scenario: Enter false credentials and try to log in
	Given On login page  
	When The credentials imputs are filled with wrong login and password
	And button login is clicked
	Then verify the page is the login page
