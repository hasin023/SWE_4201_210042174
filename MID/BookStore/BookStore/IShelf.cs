using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public interface IShelf
    {
        void Sell(string title, string author, int reqQty);

    }
}
