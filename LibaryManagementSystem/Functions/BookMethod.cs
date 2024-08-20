using LibaryManagementSystem.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagementSystem.Functions
{
    public class BookMethod
    {
        public static void printOption(Book book)
        {
            Console.WriteLine($@"|
 -----------------------------------------------------------------------------------------------------------------
|                                PLEASE CHOOSE AN OPTION:                                                         |
|                                 1. Book List<View all AVAIBLE books>                                            | 
|                                 2. Borrow Book                                                                  |
|                                 3. Return Book                                                                  |
|                                 4. Add Book                                                                     |
|                                 5. Exit                                                                         |
 -----------------------------------------------------------------------------------------------------------------

");

        }
        public static void BookListM()
        {
           //BookList bookList = new BookList();
            foreach (var book in BookList.books)
            {
                Console.WriteLine(book.Title + " " + book.Author + " " + book.Code + " " + book.Price + " " + book.Edition + " " + book.IsAvaible);
            }
        }
        public static void BorrowBook(Book book)
        {
            Console.WriteLine("Enter the book code");
            string code = Console.ReadLine();
            foreach (var b in BookList.books)
            {
                if (b.Code == code)
                {
                    book = b;
                    break;
                }
            }
            Console.WriteLine("enter student id ");
            int id = int.Parse(Console.ReadLine());

            if (book.IsAvaible)
            {
                Console.WriteLine("Book is not available");
            }
            else
            {
                Console.WriteLine("Book is available");
            }
        }

        public static void BookReturn(Book book)
        {

        }
        public static void AddBook()
        {
            Console.WriteLine();
        }
        public void WelcomeMsg()
        {

            Console.WriteLine($@"|
|
|                   __________Welcome to the CCN Library Management System__________");
            printOption(default(Book));
            int option;
            do
            {
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        BookListM();
                        break;

                    case 2:
                        BorrowBook(default(Book));
                        break;
                    case 3:
                        BookReturn(default(Book));
                        break;
                    case 4:
                        AddBook();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using the CCN Library Management System");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }


            } while (option != 0);
        }
    }
}
    

