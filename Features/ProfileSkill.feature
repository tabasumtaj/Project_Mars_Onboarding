Feature: ProfileSkill
Feature:This feature is to test user profile of MarsApplication for the following
A short summary of the feature
Create Profile for Skills and edit the language ,levels then we update the entry ,delete the entry.


Scenario Outline:A.Create a Profile for Skills
	Given User enters the valid credentials to login MarsApplication
	When User Navigate to Profile clicks on skills 
	Then Add new button is click to add skills and skilllevel 
	Then User can enter skills list in <skills> and <skillslevel>

	Examples: 
	| skills            | skillslevel     |
	| 'Manual testing ' | ' Expert '      |
	| 'C#'              | 'Beginner'      |
	| 'Jira Tool'       | 'Intermediate ' |

    Scenario:B.Edit the profile skills and skilllevel
	When User Navigate to Profile clicks on skills to update
	When User clicks on edit button to change the <skills> and <skilllevel> 
	Then User will click the update button to add <skills> with <newlevel>

	Examples: 
	| skills             | skilllevel      | newlevel       |
	| ' Manual testing ' | ' Expert '      | 'Intermediate' |
	| ' C#'              | ' Beginner '    | 'Expert'       |
	| 'Jira Tool'        | 'Intermediate ' | ' Beginner '   |

	  
    
	Scenario:C.Delete the language and level 
	Given User enters the valid credentials to login MarsApplication
    When  User Navigate to Profile page and shows the language and level
    When  User clicks delete to remove the language and pop up message is shown.
	Examples: 
	| deletelanguage | deletelevel |
	|'Urdu'         |' Fluent '   | 
	|' French'  |' Basic '        |   

