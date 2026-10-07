using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace پروژه_پایانی___کتابخونه__
{
    class Book
    {
        public int Code;
        public string Name;
        public string Author;
        public int Count;
        public int BorrowedCount;

        public Book(int code, string name, string author, int count)
        {
            Code = code;
            Name = name;
            Author = author;
            Count = count;
            BorrowedCount = 0;
        }

        public int GetCode()
        {
            return Code;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public int GetCount()
        {
            return Count;
        }

        public int GetBorrowedCount()
        {
            return BorrowedCount;
        }

        public void AddBook()
        {
            Console.Write("Book Code : ");
            Code = int.Parse(Console.ReadLine());

            Console.Write("Book Name : ");
            Name = Console.ReadLine();

            Console.Write("Book Author : ");
            Author = Console.ReadLine();

            Console.Write("Book Count : ");
            Count = int.Parse(Console.ReadLine());

            BorrowedCount = 0;

            Console.WriteLine("Ketab Ba Movafaghiat Sabt Shod.");
        }

        public void EditBook()
        {
            Console.Write("Book Name Jadid : ");
            Name = Console.ReadLine();

            Console.Write("Book Author Jadid : ");
            Author = Console.ReadLine();

            Console.Write("Book Count Jadid : ");
            Count = int.Parse(Console.ReadLine());

            Console.WriteLine("Etelaat Jadid Ketab Ba Movafaghiat Virayesh Shod.");
        }

        public void ShowBook()
        {
            Console.WriteLine("Book Code : " + Code);
            Console.WriteLine("Book Name : " + Name);
            Console.WriteLine("Book Author : " + Author);
            Console.WriteLine("Book Count : " + Count);
        }

        public void BorrowBook()
        {
            if (Count > 0)
            {
                Console.WriteLine("Ketab Ba Movafaghiat Amanat Dade Shod.");
                Count--;
                BorrowedCount++;
            }
            else
                Console.WriteLine("Ketab Mojod Nist.");
        }

        public void ReturnBook()
        {
            if (BorrowedCount > 0)
            {
                Console.WriteLine("Ketab Ba Movafaghiat Bazgardande Shod.");
                Count++;
                BorrowedCount--;
            }
            else
                Console.WriteLine("In Ketab Amanat Dade Nashode.");
        }

    }
}