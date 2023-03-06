using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes
{
    public static class CheckUser
    {
        static User _user { get; set; }
        static CentralHermes _centerHermes { get; set; }

        static void IsVerified()
        {
            if(_centerHermes._ssns == _user._ssn)
            {
                _user._userType = "Verified";
            }
            else
            {
                _user._userType = "General";
            }
        }
    }
}
