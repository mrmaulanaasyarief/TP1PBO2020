using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PBO2020
{
    class Login
    {
        public bool auth(User user)
        {
            if(user.password == "pbo123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
