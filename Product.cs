using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUser
{
    class Product
    {
        public string nom { get; set; }
        public User user { get; set; }

        public bool isValidProduct()
        {
            if (user.isValid() == false || nom == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }

}
