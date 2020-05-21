using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_8
{
    public enum Speciality
    {
        sport,
        film_music,
        actuality,
        fauna_flora
    }
    public class Member
    {
        private string _memberName;
        private Speciality _memberSpeciality;

        public Member(string memberName, Speciality speciality)
        {
            _memberName = memberName;
            _memberSpeciality = speciality;
        }

        public string Print()
        {
            var report = new StringBuilder();

            report.AppendLine($"name: {_memberName}\nSpeciality: {_memberSpeciality}");

            return report.ToString();
        }
    }
}
