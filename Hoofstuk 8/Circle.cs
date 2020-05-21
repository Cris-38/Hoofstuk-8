using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_8
{
    public class Circle
    {
        private double _ray;

        public Circle()
        {
            _ray = 7.5;
        }

        public Circle(double ray)
        {
            _ray = ray;
        }

        public void SetRay(double ray)
        {
            _ray = ray;
        }

        public double CalculateSurfaceCircle()
        {
            double result = 3.14 * Math.Pow(_ray, 2);
            return Math.Round(result, 2);
        }

        public double CalculatePerimeter()
        {
            double result = 2 * _ray * 3.14;
            return Math.Round(result, 2);
        }
    }
}
