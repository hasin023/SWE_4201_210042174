using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book : IShelf
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _author { get; set; }
        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        private int _price { get; set; }
        private int _sold { get; set; }

        public Book(string title, string author, int quantity, int price)
        {
            this._title= title;
            this._author= author;
            this._quantity= quantity;
            this._price= price;
        }

        public void Sell(string title, string author, int reqQty)
        {
            if(_title == title && _author == author && _quantity > reqQty )
            {
                int _bookLeft = _quantity - reqQty;
                Console.WriteLine($"Success!!\"{_title}\" has been sold by {reqQty} copies");
                _quantity = _bookLeft;
                _sold += reqQty;
            }
            else
            {
                Console.WriteLine($"Required copies of \"{_title}\" is not in stock!");
            }
        }

        public void Sold(string title, string author)
        {
            if (_title == title && _author == author)
            {
                Console.WriteLine($"Most Sold : {_title} by {_sold} copies");
            }
            else
            {
                Console.WriteLine("Book Not Found!");
            }
        }

        public int BookSold()
        {
            return _sold; 
        }

    }
}
