using Newtonsoft.Json;
using RestSharp_API_Testing.Specs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RestSharp_API_Testing.Specs.Steps
{
    [Binding]
    public sealed class PutRequests
    {
        private static CreatePosts posts;

        [When(@"I create put request body as")]
        public void WhenICreatePutRequestBodyAs(Table table)
        {
            posts = table.CreateInstance<CreatePosts>();

            var obj = new CreatePosts()
            {
                title = posts.title
            };

            CreatePostSteps.jsonBody = JsonConvert.SerializeObject(obj);
            Console.WriteLine(CreatePostSteps.jsonBody);
        }

    }
}
