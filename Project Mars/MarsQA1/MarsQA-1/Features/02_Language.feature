Feature: Language
As a Seller I want the feature to manage my Language details.
So that I am able to add, edit or delete my Language records.        
	
   
	Background: I am on Language Profile Page	
		
    Scenario Outline: 1 Add new Language 	
	Given I click on Add new language.
	When  I Enter '<Language>' and '<Level>'
	And Click on Add Button.
	Then I should see a validation message '<Validation_Message>'
	
	Examples: 
	| Order | Language                          | Level                   | Validation Message                                          |
	| 1     | English                           | Fluent                  | "English has been added to your languages"                  |
	| 2     |                                   | Fluent                  | "Please enter language and level"                           |
	| 3     | French                            | Choose Language Level   | "Please enter language and level"                           |
	| 4     | English                           | Fluent                  | "This language is already exist in your language list"      |
	| 5     | This is for test This is for test | Basic                   | "This is for test This is for test added to your languages" |
 
	Scenario Outline: 2 Edit Language
		Given I click on Edit icon
		When I Edit '<Language>' and '<Level>
		And I click on Update button
		Then I should see a Update validation message '<Validation_Message>'
		
	Examples: 
	  | Order | Language                            | Level           | Validation Message                                          |
	  | 1     | Spanish                             | Fluent          | "Spanish has been updated to your languages"                |
	  | 2     |                                     | Fluent          | "Please enter language and level"                           |
	  | 3     | Spanish                             | Language Level  | "Please enter language and level"                           |
	  | 4     | Spanish                             | Fluent          | "This language is already exist in your language list"      |
	  | 5     | This is for test This is for test   | Basic           | "This is for test This is for test added to your languages" |
		

	Scenario: 3 Delete Language
		When I click on Delete icon
		Then I should see a Delete validation message '<Validation_Message>'
		
	Examples: 
	| Language | Level  | Validation Message                              |
	| Spanish   | Fluent | "Spanish has been deleted from your languages" |
 
  Scenario: 4 Cancel Language
	    Given I click on Add new language.
    	When   I Enter '<Language>' and '<Level>'
        When  I click on Cancel Button.	
    
    Examples: 
       | Order | Language | Level  | 
       | 1     | Gujarati  | Fluent | 
  
    Scenario: 5 Tab Name Verification
	    Given I Click on Language tab
	    Then The name of the tab should be "Language"
	    
	
		
		
		
	 
	
	
    
    
	
	
	
		
		
	
