using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes
{
    public sealed class CentralHermes
    {
        private int _amount { get; set; } = 0;
        private User _user { get; set; }
        public int _ssns { get; set; }

        List<int> _ssn = new List<int>();

        public CentralHermes(int amount) 
        {
            this._amount = amount;
        }

        public int GetMoney()
        {
            int res = _user.Pay() + _amount;
            return res;
        }
    }
}
