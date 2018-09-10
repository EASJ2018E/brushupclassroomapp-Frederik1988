using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class SemesterClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> classList = new List<Student>(); 
        public DateTime SemesterStart { get; set; }

        public SemesterClassRoom()
        {
            
        }

        public void SeasonCount()
        {
            var StudentsInWinter = (from stud in classList where stud.BirthMonth == 12 || stud.BirthMonth <= 2 select stud).Count();
            Console.WriteLine("Winter: " + StudentsInWinter);
            var StudentsInSpring = (from stud in classList where stud.BirthMonth >= 3 && stud.BirthMonth <= 5 select stud).Count();
            Console.WriteLine("Spring: " + StudentsInSpring);
            var StudentsInSummer = (from stud in classList where stud.BirthMonth >= 6 && stud.BirthMonth <= 8 select stud).Count();
            Console.WriteLine("Summer: " + StudentsInSummer);
            var StudentsInAutumn = (from stud in classList where stud.BirthMonth >= 9 && stud.BirthMonth <= 11 select stud).Count();
            Console.WriteLine("Autumn: " + StudentsInAutumn);
        }
    }
    
     
}
