Feature: Taschenrechner
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the result of a equation

@mytag
Scenario: get sinus of a number
	Given the number is 3.14159
	When the equation is sinus
	Then the result should be 0

@mytag
Scenario: get cosinus of a number
	Given the number is 3.14159
	When the equation is cosinus
	Then the result should be -1

@mytag
Scenario: get tangens of a number
	Given the number is 3.14159
	When the equation is tangens
	Then the result should be 0