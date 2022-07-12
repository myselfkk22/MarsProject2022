Feature: Eduaction

As a seller,
I want the feature to add my Profile education Details
So that the people seeking for some skills can look into my details. 


@AddEducation
Scenario: 2-1 To add education on profile. 
	Given I signin into the Mars portal.
	When  I add education on my profile. 
	Then The Education details should be added successfully.

@EditEducation
Scenario:2-2 To update education of the seller. 
	Given I signin into the Mars portal. 
    When  I edited '<Country>','<College>','<Title>', '<Degree>', '<Year>' on an existing education record.. 
	Then The record should have edited '<Country>','<College>', '<Title>', '<Degree>', '<Year>' successfully.
	
Examples: 
	| Country     | College   | Title | Degree   | Year |
	| Australia   | Laila     | M.B.A | Business | 2008 |

@DeleteEducation
Scenario: 2-3 Delete education on profile
Given I signin into the Mars portal.
When I delete an education from an existing Education record
Then The education record should be deleted successfully.