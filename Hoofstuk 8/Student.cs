using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_8
{
    public class Student
    {
        private string _firstName;
        private string _name;
        private string _klass;

        public Student(string firstName, string name, string klass)
        {
            _firstName = firstName;
            _name = name;
            _klass = klass;
        }

        public void SetStudentFirstName(string firstName)
        {
            _firstName = firstName;
        }

        public string GetSudentFirtsName()
        {
            return _firstName;
        }

        public void SetStudentName(string Name)
        {
            _name = Name;
        }

        public string GetSudentName()
        {
            return _name;
        }

        public void SetStudentklass(string klass)
        {
            _klass = klass;
        }

        public string GetSudentKlass()
        {
            return _klass;
        }
    }
}
