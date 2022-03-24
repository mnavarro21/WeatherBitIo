Feature: Get Air Quality
Returns current observation depedending on the API Scenario

@ByCity
Scenario: Get Current Air Quality By Postcode
	Given I want to get current air quality by "POSTAL CODE"
	When I set my postal code to "28546"
	And I set my api key for get current air quality
	And I proceed to get my current air quality by postal code
	Then I should get correct air quality details by "POSTAL CODE"