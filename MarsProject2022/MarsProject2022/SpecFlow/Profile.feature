Feature: Profile

AAs a seller,
I want the feature to add my Profile Details
So that the people seeking for some skills can look into my details. short summary of the feature


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



@AddEducation
Scenario: 2-1 To add education on profile. 
	Given I logged into the Mars portal successfully. 
	When  I add education on my profile. 
	Then The Education details should be added successfully.

@EditEducation
Scenario:2-2 To update education of the seller. 
	Given I logged into the Mars portal. 
    When  I edited '<Country>','<College>','<Title>', '<Degree>', '<Year>' on an existing education record.. 
	Then The record should have edited '<Country>','<College>', '<Title>', '<Degree>', '<Year>' successfully.
	
Examples: 
	| Country     | College   | Title | Degree   | Year |
	| Australia   | Laila     | M.B.A | Business | 2008 |

@DeleteEducation
Scenario: 2-3 Delete education on profile
Given I logged into the Mars portal.
When I delete an education from an existing Education record
Then The education record should be deleted successfully.


@AddCertification
Scenario: 3-1 To add certification that seller know. 
	Given I logged into the Mars portal. 
	When  I add certification on my profile.
	Then New Certificate details will be added.

@EditCertification
Scenario: 3-2 To update certification that seller know. 
	Given I logged into the Mars portal. 
	When  I edit '<Certificate>', '<CertifiedFrom>', '<Year>'. 
	Then The Certificate should have edited '<Certificate>','<CertifiedFrom>', '<Year>' .
Examples: 
    | Certificate | CertifiedFrom | Year |
    | ISB         | TAFE            | 2016 |

@DeleteCertification
Scenario:3-3 Delete Certification on profile
Given I logged into the Mars portal.
When I delete Certification from Certification record
Then The Certification record should be deleted successfully	