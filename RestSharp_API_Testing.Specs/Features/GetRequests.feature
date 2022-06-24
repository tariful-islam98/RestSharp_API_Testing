Feature: GetRequests

@mytag
Scenario: Send get requests for all data
	Given Perform Request "posts" with "GET" method
	When Execute API
	Then response code should be 200

@mytag
Scenario: Send get requests for first post
	Given Perform Request "posts/1" with "GET" method
	When Execute API
	Then returned status code will be 200

@mytag
Scenario: Send get requests with params
	Given Perform Request "posts" with "GET" method
	When Perform URL segment for "id" with parameter "1"
	When Execute API
	Then response code should be 200

@mytag
Scenario: Send get requests for users
	Given Perform Request "users/1" with "GET" method
	When Execute API
	Then response code should be 200

@mytag
Scenario: Check geo location of the address for first user
	Given Perform Request "users/1" with "GET" method
	When Execute API
	Then City under address should be "Gwenborough"
	And geo under address should have
		| lat      | lng     |
		| -37.3159 | 81.1496 |

@mytag
Scenario: Check user name and email for a post
	Given Perform Request "posts/1" with "GET" method
	When Execute API
	And I get userId from the response
	And Perform Request on "users" with "GET" method
	And Perform URL segment for "id" with parameter
	And Execute API
	Then user response should have
		| name      | email     |
		| Leanne Graham | Sincere@april.biz |