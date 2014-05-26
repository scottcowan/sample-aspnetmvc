Feature: ContactPageFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I navigated to the contact page
	Then I see
		| Field         | Rule   | Value   |
		| Content Title | equals | Contact. |
