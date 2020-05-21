using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_8
{
    public class Fractions
    {
        private int _counter;
        private int _denominator;

        public Fractions()
        {
            _counter = 5;
            _denominator = 10;
        }

        public Fractions(int counter, int denominator)
        {
            _counter = counter;
            _denominator = denominator;
        }

        public decimal CalculateFractions()
        { 
            return (decimal)_counter / _denominator; ;
        }

        public void SetCounter(int counter)
        {
            _counter = counter;
        }

        public int GetCounter()
        {
            return _counter;
        }

        public void SetDenominator(int denominator)
        {
            _denominator = denominator;
        }

        public int GetDenominator()
        {
            return _denominator;
        }
    }
}
