using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models
{
    public class UserModel
    {
        public long UserId { get; set; }

        public string Username { get; set; }

        public string Location { get; set; }

        public int Age { get; set; }
    }
}