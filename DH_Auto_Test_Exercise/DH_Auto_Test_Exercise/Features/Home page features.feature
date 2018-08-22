Feature: Home page features

In order to test the DH UI Testing home page
As a user
I want to verify home page elements exist and work as expected


#------------------------------------------------------------------------------------------------------

@uivisible
Scenario Outline: The title UI Testing is visible regardless of the page being visited

Given I am on the DH UI Testing home website
And the title <ui_testing> is visible
When I click on button <button>
Then the title <ui_testing> is visible

Examples:

| ui_testing   | button |
|   site	   |  form  |
|   site	   |  home  |
|   site	   |  error |

#------------------------------------------------------------------------------------------------------