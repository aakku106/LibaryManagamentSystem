using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagementSystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public bool IsAvaible { get; set; }
        public int Edition { get; set; }

        public Book(string title, string auther,string code, double price,int edition)
        { 
            Title = title;
            Author = auther;
            Code = code;
            Price = price;
            IsAvaible = false;
            Edition = edition;
        }


    }
}
