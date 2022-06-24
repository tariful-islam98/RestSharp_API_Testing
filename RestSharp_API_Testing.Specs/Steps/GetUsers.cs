using Newtonsoft.Json;
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
    public sealed class GetUsers
    {
        User user;

        [Then(@"City under address should be ""(.*)""")]
        public void ThenCityUnderAddressShouldBe(string city)
        {
            this.user = JsonConvert.DeserializeObject<User>(SharedSteps.response.Content);

            Assert.That(this.user.address.city, Is.EqualTo(city));
        }

        [Then(@"geo under address should have")]
        public void ThenGeoUnderAddressShouldHave(Table table)
        {
            var location = table.CreateInstance<Geo>();

            Assert.That(this.user.address.geo.lat, Is.EqualTo(location.lat));
            Assert.That(this.user.address.geo.lng, Is.EqualTo(location.lng));
        }

    }
}
