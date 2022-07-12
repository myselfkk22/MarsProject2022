Feature: PossibleTestCases

Feature: Profile
As a seller,
I want the feature to add my Profile Details
So that the people seeking for some skills can look into my details.

@JoinSuccessfull
Scenario: Confirmation of successful Join with valid credentials
	Given Enter Mars Project home page
	When Add valid informatin on the join page
	Then The seller should be join succesfully


@SignInSuccessful
Scenario: Confirmation of successful login with valid credentials
	Given Login with valid email address and password 
	When successfully logged in to 
	Then Then the seller name shold appear in the profile page

@Search
Scenario: Search any skills with keywords
Given  I logged into the Mars portal.
When Keywork of skill to find related results in the search button
Then All the results with skills in search keyword


@EditProfileName
Scenario: Edit profile name details of the seller
Given  I logged into the Mars portal.
When Existing "<given name>' and "<last name>'
Then Then the profile name should be changed

@AddAvailability
Scenario: Add profile availabity of the seller 
Given  I logged into the Mars portal. 
When Add Availability on seller information 
Then Availability on the Seller information should be added successfully.

@EditAvailability
Scenario: Edit profile availabity of the seller 
Given  I logged into the Mars portal. 
When Edit Availability on seller information 
Then Availability on the Seller information should be edited successfully.

@AddHours
Scenario: Add profile hours  of the seller 
Given  I logged into the Mars portal. 
When Add hours on seller information 
Then hours on the Seller information should be added successfully.

@EditHours
Scenario: Edit  profile hours of the seller 
Given  I logged into the Mars portal. 
When Edit hours on seller information 
Then EarnTarget on the Seller information should be edited successfully.

@AddEarnTarget
Scenario: Add profile EarnTarget of the seller 
Given  I logged into the Mars portal. 
When Add EarnTarget on seller information 
Then EarnTarget on the Seller information should be added successfully.

@EditEarnTarget
Scenario: Edit profile EarnTarget of the seller 
Given  I logged into the Mars portal. 
When Edit EarnTarget on seller information 
Then EarnTarget on the Seller information should be edited successfully.

 


@AddDescription
Scenario: Add Description about the seller 
Given     I logged into the Mars portal. 
When   Add Description in the description Textbox 
Then Description of the seller should be saved successfully as entered. 

@EditDescription
Scenario: Edit Description about the seller 
Given     I logged into the Mars portal. 
When   Edit Description in the description Textbox 
Then Description of the seller should be edited successfully.



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
	
@AddSkills
Scenario: To add skills of the seller. 
	Given I logged into the Mars portal successfully. 
	When  I add skills on my profile.
	Then The skills details should be added successfully.

@editSkills
Scenario: To update skills of the seller. 
	Given I logged into the Mars portal successfully. 
	When  I edited '<Add Skill>', '<Choose Skill Level>' 
	Then The record should have edited '<Add Skill>', '<Choose Skill Level>' successfully.
     Examples:
	 | Add skill | Choose Skill Level |
	 | Coding    | Intermediate       |

@DeleteSkills
Scenario: Delete skills on profile
Given I logged into the Mars portal successfully
When I delete a skills from skills record
Then The skills record should be deleted successfully

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
	Then The Certificate should have edited '<Certificate>','<CertifiedFrom>', '<Year>' updated.
Examples: 
    | Certificate | CertifiedFrom | Year |
    | ISB         | TAFE            | 2016 |

@DeleteCertification
Scenario:3-3 Delete Certification on profile
Given I logged into the Mars portal.
When I delete Certification from Certification record
Then The Certification record should be deleted successfully	


