Feature: first feature file testing

Scenario: verify google search
Given user is on Google Page
When user search for a product
Then the search operation should be successful