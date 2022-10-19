Feature: Profile

A short summary of the feature	

@tag1
Scenario: Add description in the profile page
	Given I logged into the local host portal successfully
    When  I added description in the profile page
	Then The description should be added successfully

Scenario: Add language in the profile page
Given I logged into the local host portal successfully
When I added language in the profile page
Then The language should be added successfully

Scenario: Add skills in the profile page
Given I logged into the local host portal successfully
When I added skill in the profile page
Then The skill should be added successfully

