Feature: Language
         Add,Edit,Delete(CRUD) for Language 
	
   
	Background: I am on Language Profile Page	
		
    Scenario Outline: : 1 Add new Language 	
	Given I click on Add new language.
	When  I Enter '<Language>' and '<Level>'
	And Click on Add Button.
	Then I should see a validation message '<Validation_Message>'
	
	Examples: 
	| Order | Language                          | Level                   | Validation Message                                          |
	| 1     | English                           | Fluent                  | "English has been added to your languages"                  |
	| 2     |                                   | Fluent                  | "Please enter language and level"                           |
	| 3     | French                            | Choose Language Level | "Please enter language and level"                           |
	| 4     | English                           | Fluent                  | "This language is already exist in your language list"      |
	| 5     | This is for test This is for test | Basic                   | "This is for test This is for test added to your languages" |
 
	Scenario: 2 Edit Language
		Given I click on Edit icon
		When I Edit '<Language>' and '<Level>
		And I click on Update button
		Then I should see a Update validation message '<Validation_Message>'
		
	Examples: 
	  | Order | Language | Level  | Validation Message                                   |
	  | 1     | Spanish  | Fluent | "Spanish has been updated to your languages"         |
	  | 2     | Spanish  | Fluent | "This language is already exist in your language list" |
		

	Scenario: 3 Delete Language
		When I click on Delete icon
		Then I should see a Delete validation message '<Validation_Message>'
		
	Examples: 
	| Language | Level  | Validation Message                              |
	| Spanish   | Fluent | "Spanish has been deleted from your languages" |
		
		
	
