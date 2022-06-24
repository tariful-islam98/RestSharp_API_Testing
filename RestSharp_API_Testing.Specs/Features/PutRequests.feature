Feature: PutRequests
	Perform DELETE requests on the API

@mytag
Scenario: Perform PUT requests on the Posts
	Given Perform Request "posts/1" with "PUT" method
	When I create put request body as
	| title |
	| Tesst |
	And Add the serialized body to the API request
	And Execute API
	Then returned status code will be 200
