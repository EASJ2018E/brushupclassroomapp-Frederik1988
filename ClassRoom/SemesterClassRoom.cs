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
     
    }
}
