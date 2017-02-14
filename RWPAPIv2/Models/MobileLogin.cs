using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWPAPIv2.Models
{
    public class MobileLogin
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool success { get; set; }
        public string errorMessage { get; set; }
        
    }
}