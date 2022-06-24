using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_API_Testing.Specs.Models
{
    class Posts
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
