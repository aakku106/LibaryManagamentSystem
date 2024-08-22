using LibaryManagementSystem.DB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //Console.WriteLine(Book);
        }
        public static void BorrowBook(Book book)
        {
            Console.WriteLine("|    Enter the book code");
            string code = Console.ReadLine();
            foreach (var b in BookList.books)
            {
                if (b.Code == code)
                {
                    book = b;
                    break;
                }
            }
            Console.WriteLine("|    enter student id ");
            int id = int.Parse(Console.ReadLine());

            if (book.IsAvaible)
            {
                Console.WriteLine("|    Book is not available");
            }
            else
            {
                Console.WriteLine("|    Book is Borrowed");
                book.IsAvaible = true;

            }
        }

        public static void BookReturn(Book book)
        {
            Console.WriteLine("|    Enter the book code");
            string code = Console.ReadLine();
            foreach (var b in BookList.books)
            {
                if (b.Code == code)
                {
                    book = b;
                    break;
                }
            }
           

            if (book.IsAvaible)
            {
                Console.WriteLine("|    Book is Returned");
                book.IsAvaible = false;
            }
            else
            {
                Console.WriteLine("|    Error 404: book rakhni thau not found...");

            }

        }
        public static void AddBook()
        {
            Console.WriteLine("|    Enter the book title");
            string title = Console.ReadLine();
            Console.WriteLine("|    Enter the book author");
            string author = Console.ReadLine();
            Console.WriteLine("|    Enter the book code");
            string code = Console.ReadLine();
            Console.WriteLine("|    Enter the book price");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("|    Enter the book edition");
            int edition = int.Parse(Console.ReadLine());
            BookList.books.Add(new Book(title, author, code, price, edition));
            Console.WriteLine("|    Book added successfully");



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
                        Console.WriteLine("|    Thank you for using the CCN Library Management System");
                        break;
                    default:
                        Console.WriteLine("|    Invalid option");
                        break;
                }


            } while (option != 0);
        }
    }
}
    

