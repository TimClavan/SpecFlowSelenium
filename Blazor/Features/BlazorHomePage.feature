Feature: Blazor home page

Scenario: Navigate to the Blazor homepage and check it out
	Given I navigate to the home page
	When the homepage is loaded
	Then the text "Hello, World!" is present




