Feature: Language

A short summary of the feature

@1addlangauge
Scenario:(1) Add language in the profile page 
	Given  I logged into the local host portal successfully
    When  I added language in the profile page
	Then The language should be added successfully
@2editlangauge
Scenario:(2) Edit langauge in the profile page
Given I logged into the local host portal successfully
When I edit'<Language>'in the existing langauge record
Then The record should have the edited '<Language>' .

Examples: 
| Langauge |
| english  | 

@3deletelangauge
Scenario: (3) Delete langauge in the profile page
Given I logged into the local host portal successfully
When I delete language from an exisiting langauge record
Then The language should be deleted successfully

