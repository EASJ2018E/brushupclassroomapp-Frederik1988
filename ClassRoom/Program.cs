using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            SemesterClassRoom current = new SemesterClassRoom();

            current.ClassName = "3B";
            current.SemesterStart = new DateTime(2018, 9, 4);
            
            current.classList.Add(new Student("Frederik Skærbæk", 7, 12));
            current.classList.Add(new Student("Nicolai Vagner", 3, 12));
            current.classList.Add(new Student("Louis Verond", 10, 19));
            

            Console.WriteLine("The classname is: " + current.ClassName);
            Console.WriteLine("The semester started: " + current.SemesterStart);
            Console.WriteLine("The current number of students is: " + current.classList.Count);
            

            Console.ReadKey();
        }
    }
}
