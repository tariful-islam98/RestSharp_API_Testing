using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Net;
using RestSharp_API_Testing.Specs.Models;

namespace RestSharp_API_Testing.Specs.Steps
{
    [Binding]
    class GetRequestsSteps
    {
        public Posts posts = new Posts();
        public RestClient client = new RestClient("https://jsonplaceholder.typicode.com/");
        public RestRequest request = new RestRequest();
        public RestResponse response = new RestResponse();

        [Given(@"user sends request for all on ""(.*)""")]
        public void GivenUserSendsRequestForAllOn(string url)
        {
            request = new RestRequest(url, Method.Get);
        }

        [Given(@"user sends request for ""(.*)"" where ""(.*)"" is (.*)")]
        public void GivenUserSendsRequestForWhereIs(string url, string key, int value)
        {
            request = new RestRequest(url, Method.Get);
            request.AddParameter(key, value);
        }

        [Then(@"response code should be (.*)")]
        public void ThenResponseCodeShouldBe(int resp)
        {
            response = client.ExecuteAsync(request).GetAwaiter().GetResult();
            HttpStatusCode code = response.StatusCode;
            Assert.That((int)code, Is.EqualTo(resp));
        }
    }
}
