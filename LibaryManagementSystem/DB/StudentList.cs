using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagementSystem.DB
{
    internal class StudentList
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student
            {
                Id = 1,
                Name = "Aakku",
                Address = "Kathmandu",

            },
            new Student
            {
                Id = 2,
                Name = "CCN",
                Address = "Bhaktapur",

            },
           
        };
    }
}



