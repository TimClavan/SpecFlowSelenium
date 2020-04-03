Feature: BlazorCounterPageOpenen

Scenario: Test openen counter page
 Given ik navigeer naar de counter page
 Then wordt de titel "Counter" op de counter page getoond


 Scenario: Test openen counter page verifier welkomst tekst
	Given ik navigeer naar de counter page
	Then wordt de tekst "This is a simple example of a component." op de counter page getoond


Scenario: Test Increment button
	Given ik navigeer naar de counter page
	When ik klik op de increment button
	Then is de current count <Waarde>

	Examples: 
	| Waarde |
	| 1      |
