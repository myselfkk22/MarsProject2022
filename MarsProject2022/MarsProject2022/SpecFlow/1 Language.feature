Feature: Language

As a seller,
I want the feature to add my language Details
So that the people seeking for some skills can look into my details. 


@AddLanguage
Scenario: 1-1 add Language on profile. 
	Given I logged into the Mars portal. 
	When  I add language on my profile. 
	Then The language should be added successfully.


@EditLanguage
Scenario: 1-2 Edit language on profile. 
	Given I logged into the Mars portal. 
	When  I edit '<Language>' and '<LanguageLevel>' on an excisting language record. 
	Then The record should have the edited '<Language>' and '<LanguageLevel>'

Examples:
| Language  | LanguageLevel |
| Tamil     | Basic         |

@DeleteLanguage
Scenario: 1-3 Delete language on profile.
Given I logged into the Mars portal.
When I delete a language from an existing language record.
Then The language record should be deleted successfully.


