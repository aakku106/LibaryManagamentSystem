using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagementSystem
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        public string Faculity { get; set; }
        public string Semester { get; set; }
        public string Roll { get; set; }

        public List<Student> Students { get; set; }


        //public Student(string name, string address, string gender) 
        //{
        //    Id = 0;
        //    Name = "";
        //    Address = "";
        //    Email = "";
        //    PhoneNo = "";
        //}
        

    }
}
