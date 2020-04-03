Feature: BlazorHomePageOpenen
 

Scenario: Test openen home page
    Given ik navigeer naar de home page
    Then wordt de titel "Hello, World!" op de homepage getoond

Scenario: Test openen home page verifier welkomst tekst
	Given ik navigeer naar de home page
	Then wordt de tekst "Welcome to your new single-page application." op de homepage getoond
