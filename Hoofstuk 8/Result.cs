using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_8
{
    public class Result
    {
        public int points { get; }

        public Result(int points)
        {
            this.points = points;
        }

        public string FinalRaport()
        {
            var report = "";

            if (points < 50)
            {
                 return "Failed";
            }
            else if (points > 50 && points < 68)
            {
                report = "sufficient";
            }
            else if (points > 68 && points < 75)
            {
                report = "Award";
            }
            else if (points > 75 && points < 85)
            {
                report = "Great Award";
            }
            else if (points > 85)
            {
                report = "Greatest Award";
            }
            return report;
        }
    }
}
