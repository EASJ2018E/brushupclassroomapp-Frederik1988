using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        private string _name;
        private int _birthMonth;
        private int _birthDate;

        public Student(string name, int birthMonth, int birthDate)
        {
            name = _name;
            birthMonth = _birthMonth;
            birthDate = _birthDate;
        }

        public string Name
        {
            get { return _name; }
        }

        public int BirthMonth
        {
            get { return _birthMonth; }
        }

        public int BirthDate
        {
            get { return _birthDate; }
        }
    }

}
