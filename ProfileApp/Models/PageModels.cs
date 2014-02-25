using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfileApp.Models
{
    public class LoginModel
    {
        
        public string UserName { get; set; }

        
        public string Password { get; set; }

        
        public bool RememberMe { get; set; }
    }

    public class PageVariables
    {
        public PageVariables()
        {
        }
        public string Environment
        {
            get;
            set;
        }

        public string HarborKey
        {
            get;
            set;
        }

        public string TestKey
        {
            get;
            set;
        }

        public string UniqueKey
        {
            get;
            set;
        }
    }
}