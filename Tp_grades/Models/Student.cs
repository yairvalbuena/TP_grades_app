using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tp_grades.Models
{
    public class Student
    {

        public int Id { get; set; }
        public string Student_Name { get; set; }
        public string Student_Last_Name { get; set; }
        public string Grade_1 { get; set; }
        public string Grade_2 { get; set; }
        public string Grade_3 { get; set; }
        public string Grade_average { get; set; }


        public Student()
        {

        }
    }
}
