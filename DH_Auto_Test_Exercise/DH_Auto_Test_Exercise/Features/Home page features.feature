Feature: DH Features to test UI Testing home page

In order to test the DH UI Testing home page
As a user
I want to verify home page elements exist and work as expected


#------------------------------------------------------------------------------------------------------

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

@logovisible
Scenario Outline: The title UI Testing is visible regardless of the page being visited

Given I am on the DH UI Testing home website
And the DH logo is visible
When I click on button <button>
Then the title of the site UI Testing is visible

Examples:

| button |
|  form  |
|  home  |
|  error |
 