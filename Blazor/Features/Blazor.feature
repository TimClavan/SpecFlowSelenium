Feature: Blazor
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Navigate to the Blazor homepage and check it out
	Given I navigate to the home page
	When the homepage is loaded
	Then the text "hello world" is present

