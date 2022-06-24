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
    public sealed class CreateUserSteps
    {
        private static User user;
        private static Geo geo;
        private static Address address;
        private static Company company;

        [When(@"I set geo location as")]
        public void WhenISetGeoLocationAs(Table table)
        {
            geo = table.CreateInstance<Geo>();
        }

        [When(@"I set address info as")]
        public void WhenISetAddressInfoAs(Table table)
        {
            address = table.CreateInstance<Address>();
            address.geo = geo;
        }

        [When(@"I set company info as")]
        public void WhenISetCompanyInfoAs(Table table)
        {
            company = table.CreateInstance<Company>();
        }

        [When(@"I create a request body with the following values for users")]
        public void WhenICreateARequestBodyWithTheFollowingValuesForUsers(Table table)
        {
            user = table.CreateInstance<User>();

            user.address = address;
            user.company = company;

            var obj = new User()
            {
                name = user.name,
                username = user.username,
                email = user.email,
                address = address,
                phone = user.phone,
                website = user.website,
                company = company
            };

            CreatePostSteps.jsonBody = JsonConvert.SerializeObject(obj);
            Console.WriteLine(CreatePostSteps.jsonBody);
        }
    }
}
