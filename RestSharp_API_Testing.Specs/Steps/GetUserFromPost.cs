using Newtonsoft.Json;
using RestSharp;
using RestSharp_API_Testing.Specs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace RestSharp_API_Testing.Specs.Steps
{
    [Binding]
    public sealed class GetUserFromPost
    {
        Posts posts;
        String userId;

        [When(@"I get userId from the response")]
        public void WhenIGetUserIdFromTheResponse()
        {
            posts = JsonConvert.DeserializeObject<Posts>(SharedSteps.response.Content);

            userId = posts.userId;
        }

        [When(@"Perform Request on ""(.*)"" with ""(.*)"" method")]
        public void WhenPerformRequestOnWithMethod(string url, Method method)
        {
            SharedSteps.request = new RestRequest(url, method);
            SharedSteps.request.RequestFormat = DataFormat.Json;
        }

        [When(@"Perform URL segment for ""(.*)"" with parameter")]
        public void WhenPerformURLSegmentForWithParameter(string key)
        {
            SharedSteps.request.AddParameter(key, userId);
        }

        [Then(@"user response should have")]
        public void ThenUserResponseShouldHave(Table table)
        {
            var user = JsonConvert.DeserializeObject<List<User>>(SharedSteps.response.Content).FirstOrDefault();
            var tableContent = table.CreateInstance<User>();

            Console.WriteLine(user.username);
            Console.WriteLine(user.email);

            Assert.That(user.name, Is.EqualTo(tableContent.name));
            Assert.That(user.email, Is.EqualTo(tableContent.email));
        }

    }
}
