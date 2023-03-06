using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            Book _b1 = new Book("To kill a mocking bird", "Harper Lee", 10, 240);
            books.Add( _b1 );
            Book _b2 = new Book("In Search of Lost Time", "Marcel Proust", 7, 450);
            books.Add( _b2 );
            Book _b3 = new Book("Ulysses", "James Joyce", 13, 320);
            books.Add( _b3 );
            Book _b4 = new Book("Don Quixote", "Miguel de Cervantes", 11, 570);
            books.Add( _b4 );

            _b2.Sell("In Search of Lost Time", "Marcel Proust", 3);
            _b2.Sell("In Search of Lost Time", "Marcel Proust", 3);
            _b2.Sell("In Search of Lost Time", "Marcel Proust", 3);

            _b3.Sell("Ulysses", "James Joyce",4);
            _b3.Sell("Ulysses", "James Joyce", 4);
            _b3.Sell("Ulysses", "James Joyce", 4);
            _b3.Sell("Ulysses", "James Joyce", 4);

            _b2.Sold("In Search of Lost Time", "Marcel Proust");
            _b3.Sold("Ulysses", "James Joyce");

            int _mostSold = 0;

            int _maximum1 = Math.Max(Convert.ToSByte(_b1.BookSold()), Convert.ToSByte(_b2.BookSold()));
            int _maximum2 = Math.Max(Convert.ToSByte(_b3.BookSold()), Convert.ToSByte(_b4.BookSold()));

            _mostSold = Math.Max(_maximum1, _maximum2);

            foreach (Book book in books)
            {    
                if(_mostSold <= book.Quantity)
                {
                    Console.WriteLine($"Most Sold Book is {book.Title} by {_mostSold} copies");
                    break;
                }
                
            }


            Console.ReadKey();
        }
    }
}
