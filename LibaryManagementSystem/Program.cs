using LibaryManagementSystem.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book B1 = new Book(title:"C programming", auther:"CCN" ,code:"CP123",price: 106.106, edition:1 );
            Book B2 = new Book(title: "C++", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2);
            Book B3 = new Book(title: "C++", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2);
            
            BookMethod book = new BookMethod();
            book.WelcomeMsg();
            Console.ReadLine();

        }
       
    }
}
