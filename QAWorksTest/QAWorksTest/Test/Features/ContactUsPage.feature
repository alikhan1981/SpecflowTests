Feature: ContactUs
	 As an end user
  I want a contact us page
  So that I can find out more about QAWorks exciting services


  Scenario: Valid Submission
    Given I am on the QAWorks Staging Site
	When I am on Contactus page
    Then I should be able to contact QAWorks with the following information
     | field                        | Value                                     |
     | ctl00_MainContent_NameBox    | j.Bloggs                                  |
     | ctl00_MainContent_EmailBox   | j.Bloggs@qaworks.com                      |
     | ctl00_MainContent_MessageBox | please contact me I want to find out more |

Scenario: Validate all three fields are  mandatory
 Given I am on the QAWorks Staging Site
	When I am on Contactus page
    And I leave email address field empty
     | field                        | Value                                     |
     | ctl00_MainContent_NameBox    | j.Bloggs                                  |
     | ctl00_MainContent_EmailBox   |                       |
     | ctl00_MainContent_MessageBox | please contact me I want to find out more |
	Then I should see error message as "email address required"

	When I leave name field empty
	 | field                        | Value                                     |
     | ctl00_MainContent_NameBox    |                                   |
     | ctl00_MainContent_EmailBox   | j.Blogs@test.com                      |
     | ctl00_MainContent_MessageBox | please contact me I want to find out more |
	 Then I should see error message as "name required"

     When I leave message field empty
	 | field                        | Value                                     |
     | ctl00_MainContent_NameBox    | J.Bloggs                                  |
     | ctl00_MainContent_EmailBox   | j.Blogs@test.com                      |
     | ctl00_MainContent_MessageBox |  |
	 Then I should see error message as "message required"


Scenario Outline: validate email address accepts valid format
Given I amon QAWorks Staging Site
When I enter invalid email '<invalidEmail>'
And I enter name "jbloggs"
And I enter message "Please contact me"
And I submit form
Then I should see error message as "Please enter valid email address"
Examples: 
| invalidEmail |
| blogss.com   |
| blogss@      |
| @@@          |
| 12323        |

#verify max length chars which can be entered in name field, message field.
#Verify no scripted tags can be entered in the form such as html tags.