using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public abstract class Shapes
    {
        protected int _sides { get; set; }
        protected int _points { get; set; }
        protected double _area { get; set; }


        public Shapes(int sides, int points) 
        {
            this._sides= sides;
            this._points= points;
        }

        public abstract void Show();

        public void GetClassName()
        {
            Console.WriteLine("This is the Shapes Class");
        }

        public virtual double GetArea()
        {
            return _area;
        }
    }
}
