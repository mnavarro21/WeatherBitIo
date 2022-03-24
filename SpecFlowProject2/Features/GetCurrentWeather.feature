Feature: Get Current Weather
Returns current observation depedending on the API Scenario

@ByCity
Scenario: Get Current Weather By City
	Given I want to get current weather by "city"
	When I set my city to "4487042"
	And I set my api key
	And I proceed to get my current weather by city
	Then I should get correct weather details by city

@ByCities
Scenario: Get Current Weather By Cities
	Given I want to get current weather by "cities"
	When I set my city to "4487042, 4494942, 4504871"
	And I set my api key
	And I proceed to get my current weather by city
	Then I should get correct weather details by cities

@ByLatLong
Scenario: Get Current Weather By Latitude Longitude
	Given I want to get current weather by "LAT LONG"
	When I set my latitude to "38"
	And I set my longitude to "-78.25"
	And I set my api key
	And I proceed to get my current weather by latitude longitude
	Then I should get correct weather details by latitude longitude