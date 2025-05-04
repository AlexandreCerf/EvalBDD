Feature: LoginIsOk

Sur la page de login entrer le login et le mot de passe afin de valider la connection et s'assurer que l'on se trouve bien sur la page du portail

@tag1
Scenario: EnterCredentialsAndLogin
	Given On login page  
	When The credentials imputs are filled with good login and password
	And button login is clicked
	Then verify the page is the portal page
