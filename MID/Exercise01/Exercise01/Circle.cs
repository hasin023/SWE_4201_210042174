using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Circle : Shapes
    {
        private int _radius { get; set; }
        public Circle(int sides, int radius, int points) : base(sides, points)
        {
            this._radius = radius;
        }

        public override void Show()
        {
            Console.WriteLine($"This shape has {_sides} sides & a radius of {_radius}");
        }

        public override double GetArea()
        {
            _area= Math.PI*Math.Pow(_radius,2);
            return _area;
        }
    }
}
