using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes
{
    public class User
    {
        private string _name { get; set; }
        public int _ssn { get; set; }
        public string _userType { get; set; }
        public int _userAmount { get; set; }

        public JewelryItems _jItem { get; set; }
        public ClothingItems _cItem { get; set; }

        public User(string name, int ssn, int userAmount, JewelryItems jItem, ClothingItems cItem) 
        {
            this._name= name;
            this._ssn = ssn;
            this._userType = "General";
            this._userAmount = userAmount;
            this._jItem = jItem;
            this._cItem = cItem;
        }

        public int Pay()
        {
            int _total = _cItem._quantity*_cItem._price + _jItem._quantity*_jItem._price;
            return _total;
        }

        public int Left()
        {
            int _total = _cItem._quantity * _cItem._price + _jItem._quantity * _jItem._price;
            int _left = _userAmount - _total;
            return _left;
        }



    }


}
