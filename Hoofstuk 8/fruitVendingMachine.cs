using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_8
{
    public class FruitVendingMachine
    {
        private int _apples = 0;
        private int _pears = 0;

        public int Apples { get; }
        public int Pears { get; }

        public FruitVendingMachine()
        {

        }
        public FruitVendingMachine(int apples, int pears)
        {
            AppleFill(apples);
            PearsFill(pears);
        }

        public void AppleFill(int apples)
        {
            if (_apples + apples > 50)
            {
                throw new ArgumentOutOfRangeException(nameof(_apples), "Quantity most be no more than 50 apples");
            }

            _apples += apples;
        }

        public void PearsFill(int pears)
        {
            if (_pears + pears > 50)
            {
                throw new ArgumentOutOfRangeException(nameof(_pears), "Quantity most be no more than 50 pears");
            }
            _pears += pears;
        }

        public void BuyApples(int apples)
        {
            if (_apples - apples < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_apples), "There are no more apples in machine");
            }
            _apples -= apples;
        }

        public void BuyPears(int pears)
        {
            if (_pears - pears <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_pears), "There are no more apples in machine");
            }
             _pears -= pears;
        }

        public string AlertIfAppleRefill()
        {
            var report = "";
            
            if (_apples <= 0)
            {
                report = "Apples empty! Refill!";   
            }
            return report;
        }

        public string AlertIfPearsRefill()
        {
            var report = "";

            if (_pears <= 0)
            {
                report = "Pears empty! Refill!";
            }
            return report;
        }
    }
}
