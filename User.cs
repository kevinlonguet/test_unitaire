using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testUser
{
    class User
    {
        public string email { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public int age { get; set; }

        public bool isValid()
        {
            Regex rgx = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if(email == null || !rgx.IsMatch(email)|| nom == null || prenom == null || age < 13)
            {
                return false;
            } else
            {
                return true;
            }

        }
    }
}
