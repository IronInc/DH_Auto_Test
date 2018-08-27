Feature: DH Features to test UI Testing website

In order to test the DH UI Testing website
As a user
I want to verify page elements and functionalities exist and work as expected


#------------------------------------------------------------------------------------------------------

@moderate
@uivisible
Scenario Outline: The title UI Testing is visible regardless of the page being visited

Given I am on the DH UI Testing home website
And the title of the site UI Testing is visible
When I click on button <button>
Then the title of the site UI Testing is visible

Examples:

| button |
|  form  |
|  home  |
|  error |

#------------------------------------------------------------------------------------------------------

@moderate
@logovisible
Scenario Outline: The DH logo is visible regardless of the page being visited

Given I am on the DH UI Testing home website
And the DH logo is visible
When I click on button <button>
Then the DH logo is visible

Examples:

| button |
|  form  |
|  home  |
|  error |

#------------------------------------------------------------------------------------------------------

@low
@homeactive
Scenario Outline: Clicking on home \ form button renders such button active

Given I am on the DH UI Testing home website
When I click on button <button>
Then home page is active

Examples:

| button |
|  form  |
|  home  |


#------------------------------------------------------------------------------------------------------

@high
@buttonleads
Scenario Outline: Clicking on home button leads to home page, clicking on form button leads to Form page and clicking on UI Testing site title leads to home page

Given I am on the DH UI Testing home website
When I click on button <site_type>
Then I am on <site_type> page

Examples:

| site_type |
| form		|
| home		|
| site		|

#------------------------------------------------------------------------------------------------------

@low
@texth1home
Scenario: Home page features the text "Welcome to the Docler Holding QA Department" in h1

Given I am on the DH UI Testing home website
When I click on button "home"
Then the text in h1 should read "Welcome to the Docler Holding QA Department"

#------------------------------------------------------------------------------------------------------

@low
@textphome
Scenario: Home page features the text "This site is dedicated to perform some exercises and demonstrate automated web testing." in p

Given I am on the DH UI Testing home website
When I click on button "home"
Then the text in p should read "This site is dedicated to perform some exercises and demonstrate automated web testing."

#------------------------------------------------------------------------------------------------------

@high
@elementsform
Scenario: Check the input box and the input button are visible

Given I am on the DH UI Testing home website
When I click on button "form"
Then the input box is visible
And the input button is visible

#------------------------------------------------------------------------------------------------------

@high
@inputform
Scenario Outline: Input a value in home field and see submission leads to Hello page

Given I am on the DH UI Testing home website
When I click on button "form"
And I enter value "<value>" in the input box
And I submit the form
Then I check the hello page with <value> is displayed

Examples:

	| value	|
	| World |

#------------------------------------------------------------------------------------------------------

@high
@errorpage
Scenario: Clicking on error tab leads to error page 404

Given I am on the DH UI Testing home website
When I click on button "error"
Then I check a 404 error is displayed

#------------------------------------------------------------------------------------------------------