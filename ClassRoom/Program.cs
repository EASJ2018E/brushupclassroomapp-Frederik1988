using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            current.classList.Add(new Student("Rasmus", 13, 5));


            Console.WriteLine("The classname is: " + current.ClassName + "\n");
            Console.WriteLine("The semester started: " + current.SemesterStart + "\n");
            Console.WriteLine("The current number of students is: " + current.classList.Count + "\n");

            Console.WriteLine("The following students are attending the class: \n");
            current.classList.ForEach(Console.WriteLine);

            Console.WriteLine("\nThe number of birthdays in each season is: \n");
            current.SeasonCount();
            
            Console.ReadKey();
        }
    }
}
