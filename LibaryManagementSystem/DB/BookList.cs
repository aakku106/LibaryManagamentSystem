using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagementSystem.DB
{
    public class BookList
    {

        public static List<Book> books = new List<Book>()
            {
                new Book(title: "C programming", auther: "CCN", code: "CP123", price: 106.106, edition: 1),
                new Book(title: "C++", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2),
                new Book(title: "Maths", auther: "CCN", code: "CP=106", price: 1069.106, edition: 2),
                new Book(title: "stat", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2),
                new Book(title: "DS", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2),
                new Book(title: "MP", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2),
            };
            ////books.Add(new Book(title: "C++", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2));
            //books.Add(new Book(title: "Maths", auther: "CCN", code: "CP=106", price: 1069.106, edition: 2));
            //books.Add(new Book(title: "stat", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2));
            //books.Add(new Book(title: "DS", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2));
            //books.Add(new Book(title: "MP", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2));
            //books.Add(new Book(title: "IT", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2));
            //books.Add(new Book(title: "DSA", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2));
            //books.Add(new Book(title: "DataBase", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2));
            //books.Add(new Book(title: "CA", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2));
            //books.Add(new Book(title: "C#", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2));
            //books.Add(new Book(title: "Social", auther: "Aakku", code: "CP=106", price: 1069.106, edition: 2));
        
    }
}
