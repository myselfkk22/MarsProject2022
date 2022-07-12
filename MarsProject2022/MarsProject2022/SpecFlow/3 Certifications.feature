Feature: Certification


As a seller,
I want the feature to add my Profile certification Details
So that the people seeking for some skills can look into my details. 

@AddCertification
Scenario: 3-1 To add certification that seller know. 
	Given I login into the Mars portal. 
	When  I add certification on my profile.
	Then New Certificate details will be added.

@EditCertification
Scenario: 3-2 To update certification that seller know. 
	Given I login into the Mars portal. 
	When  I edit '<Certificate>', '<CertifiedFrom>', '<Year>'. 
	Then The Certificate should have edited '<Certificate>','<CertifiedFrom>', '<Year>' .
Examples: 
    | Certificate | CertifiedFrom | Year |
    | ISB         | TAFE            | 2016 |

@DeleteCertification
Scenario:3-3 Delete Certification on profile
Given I login into the Mars portal.
When I delete Certification from Certification record
Then The Certification record should be deleted successfully	