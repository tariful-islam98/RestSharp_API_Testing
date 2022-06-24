using RestSharp_API_Testing.Specs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using RestSharp.Serializers.Json;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RestSharp_API_Testing.Specs.Steps
{
    [Binding]
    public sealed class CreatePostSteps
    {
        private static CreatePosts posts;
        public static string jsonBody;

        [When(@"I create a request body with the following values")]
        public void WhenICreateARequestBodyWithTheFollowingValues(Table table)
        {
            posts = table.CreateInstance<CreatePosts>();

            var obj = new CreatePosts()
            {
                userId = posts.userId,
                title = posts.title,
                body = posts.body
            };

            jsonBody = JsonConvert.SerializeObject(obj);
            Console.WriteLine(jsonBody);
        }

        [When(@"Add the serialized body to the API request")]
        public void WhenAddTheSerializedBodyToTheAPIRequest()
        {
            SharedSteps.request.AddJsonBody(jsonBody);
        }

    }
}
