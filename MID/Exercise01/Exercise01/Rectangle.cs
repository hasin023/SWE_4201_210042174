using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Rectangle : Shapes
    {
        private int _x;
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                if(value > 0)
                {
                    _x = value;
                }
            }
        }
        private int _y;

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value > 0)
                {
                    _y = value;
                }
            }
        }


        public Rectangle(int sides,int x, int y, int points) : base(sides, points)
        {
            this._x= x;
            this._y= y;
        }

        public override void Show()
        {
            Console.WriteLine($"This shape has {_sides} sides which are {_x} & {_y}");
        }

        public override double GetArea()
        {
            _area = _x*_y;
            return _area;
        }

        public bool IsShape
        {
            get
            {
                return true;
            }
        }
    }
}
