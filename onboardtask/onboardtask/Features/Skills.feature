Feature: Skills

A short summary of the feature


@1addskill
Scenario:(1) Add skill in the profile page 
	Given  I logged into the local host portal successfully
    When  I added skill in the profile page
	Then The skill should be added successfully

@2editskill
Scenario:(2) Edit skill in the profile page
Given I logged into the local host portal successfully
When I edit'<Skill>','<Skill level>',in the existing skill record
Then The record should have the edited '<Skill>' ,'<Skill level>' .

Examples: 
| Skill | Skill level |
| PAINT | Expert      |

@3deleteskill
Scenario:(3) Delete skill in the profile page
Given I logged into the local host portal successfully
When I delete skill from an exisiting skill record
Then The skill should be deleted successfully
