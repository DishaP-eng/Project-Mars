Feature: Skills
Add,Edit,Delete(CRUD) for Skills
	
   
    Background: I am on Skills Profile Page	
		
    Scenario Outline: : 1 Add new Skill 	
        Given I click on Add new Skill
        When  I Enter '<Skill>' and '<Level>' in skill feature
        And I Click on Add Button of Skill feature
        Then I should see a Skill Validation message '<Validation_Message>'
	
        Examples: 
          | Order | Skill                             | Level              | Validation Message                                       |
          | 1     | Math                              | Expert             | "Math has been added to your Skills"                     |
          | 2     |                                   | Beginner           | "Please enter Skill and experience level"                |
          | 3     | Communication                     | Choose Skill Level | "Please enter Skill and experience level"                |
          | 4     | Math                              | Expert             | "This skill is already exist in your skill list"         |
          | 5     | This is for test This is for test | Intermediate       | "This is for test This is for test added to your skills" |
 
    Scenario: 2 Edit Skill
        Given I click on Edit icon for skill
        When I Update '<Skill>' and '<Level> in skill feature
        And I click on Update button for skill
        Then I should see a Skill Update validation message '<Validation_Message>'
		
    Examples: 
      | Order | Skill   | Level    | Validation Message                        |
      | 1     | Science | Expert | "Science has been updated to your Skills" |
      | 2     | Science | Expert | "This skill is already exist in your language list" |
		

    Scenario: 3 Delete Skill
        When I click on Delete icon for Skill
        Then I should see a Skill Delete validation message '<Validation_Message>'
		
    Examples: 
      | Skill   | Level    | Validation Message |
      | Science | Beginner | "Science has been deleted"  |