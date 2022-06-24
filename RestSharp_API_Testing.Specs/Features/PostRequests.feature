Feature: PostRequests
	Perform POST requests on the API

@mytag
Scenario: Perform post request on Posts
	Given Perform Request "posts" with "POST" method
	When I create a request body with the following values
		| userId | title    | body                       |
		| 1      | api test | testing api with restsharp |
	And Add the serialized body to the API request
	And Execute API
	Then returned status code will be 201

@mytag
Scenario: Perform post request on Users
	Given Perform Request "users" with "POST" method
	When I set geo location as
	| lat   | lng   |
	| 45.00 | 90.00 |
	And I set address info as
	| street | suite     | city | zipcode |
	| abc    | suite 444 | dhk  | 1234    |
	And I set company info as
	| name   | catchPhrase | bs       |
	| testcom | test api    | test all |
	When I create a request body with the following values for users
		| name | username | email         | phone             | website  |
		| 1    | test     | test@mail.com | 1-3234-35235-2453 | test.com |
	And Add the serialized body to the API request
	And Execute API
	Then returned status code will be 201

