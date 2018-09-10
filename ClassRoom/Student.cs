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
            if (birthMonth >= 1 && birthMonth <= 12)
            {
                _birthMonth = birthMonth;
            }
            else
            {
                throw new ArgumentException(birthMonth + " is not a valid month");
            }
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
        
        public string Season(int birthmonth)
        {
            if (birthmonth <= 2 || birthmonth == 12)
            {
                return "winter";
            }

            if (birthmonth >= 3 && birthmonth <= 5)
            {
                return "spring";
            }

            if (birthmonth >= 6 && birthmonth <= 8)
            {
                return "summer";
            }

            if (birthmonth >= 9 && birthmonth <= 11)
            {
                return "autumn";
            }
            return null;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(BirthMonth)}: {BirthMonth}, {nameof(BirthDate)}: {BirthDate}, Season: {(Season(BirthMonth))}";
        }

       
     
    }

}
