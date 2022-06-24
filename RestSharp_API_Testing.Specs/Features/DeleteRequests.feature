Feature: DeleteRequests
	Perform DELETE requests on the API

@mytag
Scenario: Perform delete on posts
	Given Perform Request "posts/100" with "DELETE" method
	When Execute API
	Then response code should be 200
