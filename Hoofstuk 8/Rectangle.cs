using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_8
{
    public class Rectangle
    {
        private int _base;
        private int _higth;

        public Rectangle(int baseNum, int higth)
        {
            _base = baseNum;
            _higth = higth;
        }

        public int CalculateRectangle()
        {
            return _base * _higth;
        }

        public void SetBase(int baseNum)
        {
            _base = baseNum;
        }

        public int GetBase()
        {
            return _base;
        }

        public void SetHigth (int higth)
        {
            _base = higth;
        }

        public int GetHigth()
        {
            return _higth;
        }
    }
}
