using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_API_Testing.Specs.Models
{
    class CreatePosts
    {
        public string userId { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
