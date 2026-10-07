using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace پروژه_پایانی___کتابخونه__
{
    class Report
    {
        public void ShowBorrowedBooks(Library lib)
        {
            Console.WriteLine();
            Console.WriteLine("---------- Ketab Haye Amanat Dade Shode ----------");

            bool found = false;

            for (int i = 0; i < lib.BookCount; i++)
            {
                if (lib.Books[i] != null && lib.Books[i].GetBorrowedCount() > 0)
                {
                    Console.WriteLine("Book Code : " + lib.Books[i].GetCode());
                    Console.WriteLine("Book Name : " + lib.Books[i].GetName());
                    Console.WriteLine("Book Author : " + lib.Books[i].GetAuthor());
                    Console.WriteLine("Tedad Amanat : " + lib.Books[i].GetBorrowedCount());
                    Console.WriteLine("-------------------");

                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Hich ketabi Amanat Dade Nashode.");
        }

        public void ShowAvailableBooks(Library lib)
        {
            Console.WriteLine();
            Console.WriteLine("---------- Ketab Haye Mojod ----------");

            bool found = false;

            for (int i = 0; i < lib.BookCount; i++)
            {
                if (lib.Books[i] != null && lib.Books[i].GetCount() > 0)
                {
                    lib.Books[i].ShowBook();
                    Console.WriteLine("-------------------");

                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Hich ketabi Mojod Nist.");
        }

        public void ShowMembers(Library lib)
        {
            Console.WriteLine();
            Console.WriteLine("---------- Ozv Haye Ketabkhone ----------");

            if (lib.MemberCount == 0)
            {
                Console.WriteLine("Hich ozvi sabt nashode.");
                return;
            }

            for (int i = 0; i < lib.MemberCount; i++)
            {
                if (lib.Members[i] != null)
                {
                    lib.Members[i].ShowMember();
                    Console.WriteLine("-------------------");
                }
            }
        }

        public void FinalReport(Library lib)
        {
            Console.WriteLine();
            Console.WriteLine("========== Gozaresh Nahayi ==========");

            Console.WriteLine("Tedad Ketab Ha : " + lib.BookCount);
            Console.WriteLine("Tedad Ozv Ha : " + lib.MemberCount);

            ShowBorrowedBooks(lib);
            ShowAvailableBooks(lib);
            ShowMembers(lib);
        }
    }
}