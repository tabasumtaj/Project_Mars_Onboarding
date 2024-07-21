Feature:This feature is to test user profile of MarsApplication for the following
A short summary of the feature
Create Profile for language and edit the language ,levels then we update the entry ,delete the entry.

Scenario Outline:A.Create profile using languages and level
	Given User enters the valid credentials to login MarsApplication
	When  User Navigate to Profile page and clicks Add new button to add Language and level 
	Then User enters maximum four languages <language> and <level>
	Examples: 
	| language  | level     |
	| 'English '| 'Fluent'      |
	|' Hindi'   |' Conversational ' |   
	|' Urdu'    |' Fluent '   |   
	|' French'  |' Basic '   |   

	Scenario: B.Edit the profile language and level
	When  User Navigate to Profile page to show Language and level 
	When User clicks on edit to change the <language> and <level> 
	Then User will click the update button to update <language> and <newlevel>

	
	Examples: 
	| language   | level              | newlevel  |
	| ' Hindi'   | ' Conversational ' | 'Fluent'  |
	| 'English ' | 'Fluent'           | ' Basic ' |
	  
    
	Scenario:C.Delete the language and level 
	Given User enters the valid credentials to login MarsApplication
    When  User Navigate to Profile page and shows the language and level
    When  User clicks delete to remove the language and pop up message is shown.
	Examples: 
	| deletelanguage | deletelevel |
	|'Urdu'         |' Fluent '   | 
	|' French'  |' Basic '        |   

	
  