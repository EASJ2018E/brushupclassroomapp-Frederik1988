using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
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
            _name = name;
            _birthMonth = birthMonth;
            _birthDate = birthDate;
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


        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(BirthMonth)}: {BirthMonth}, {nameof(BirthDate)}: {BirthDate}";
        }

       
     
    }

}
