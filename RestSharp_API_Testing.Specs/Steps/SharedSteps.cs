using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace RestSharp_API_Testing.Specs.Steps
{
    [Binding]
    public sealed class SharedSteps
    {
        #region Public variables for api
        public static RestClient client = new RestClient("https://jsonplaceholder.typicode.com/");
        public static RestRequest request;
        public static RestResponse response;
        #endregion

        [Given(@"Perform Request ""(.*)"" with ""(.*)"" method")]
        public void GivenCreateRequestWithMethod(string _request, Method _method)
        {
            request = new RestRequest(_request, _method);
            request.RequestFormat = DataFormat.Json;
        }


        [When(@"Perform URL segment for ""(.*)"" with parameter (.*)")]
        public void ThenCreateURLSegmentForWithParameter(string _segment, string _parameter)
        {
            request.AddParameter(_segment, _parameter);
        }

        [When(@"Execute API")]
        public void ThenExecuteAPI()
        {
            response = client.Execute(request);
        }

        [Then(@"returned status code will be (.*)")]
        public void ThenReturnedStatusCodeWillBe(int _status)
        {
            var code = response.StatusCode;
            Assert.That((int)code, Is.EqualTo(_status));
        }
    }
}
