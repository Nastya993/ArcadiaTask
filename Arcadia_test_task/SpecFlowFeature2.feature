Feature: EuromoneyStore 
	As a user
	I want to see International Financial Law Review on Our Portfolio -> Legal Media Page
	So that I can reach it and see subscription info

@firstSuite
Scenario: Story2
	Given I have opened start page 
	When I click Legal Media menu 
	Then On Legal Media Page I can find Financial Law Review info
	When I Click visit IFLR button
	Then IFLR main page opens in new tab
	When I click Subscribe button
	And I can select Personal package
	Then The prices are in Pounds
	And 12 Months package is pre-selected 


