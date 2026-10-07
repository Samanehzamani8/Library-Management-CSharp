using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace پروژه_پایانی___کتابخونه__
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            int choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("---------- Ketabkhone ----------");
                Console.WriteLine("1- Sabt Ketab");
                Console.WriteLine("2- Hazf Ketab");
                Console.WriteLine("3- Virayesh Ketab");
                Console.WriteLine("4- Sabt Ozv");
                Console.WriteLine("5- Jostojoye Ketab");
                Console.WriteLine("6- Amanat Ketab");
                Console.WriteLine("7- Bazgardandan Ketab");
                Console.WriteLine("8- Namayesh Ghafaseha");
                Console.WriteLine("9- Gozaresh Ketabkhone");
                Console.WriteLine("0- Khorooj");
                Console.Write("Entekhab shoma : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Book newBook = new Book(0, "", "", 0);
                        newBook.AddBook();
                        lib.AddBook(newBook);
                        break;

                    case 2:
                        Console.Write("Code Ketab baraye hazf : ");
                        int delCode = int.Parse(Console.ReadLine());
                        lib.DeleteBook(delCode);
                        break;

                    case 3:
                        Console.Write("Code Ketabi ke mikhay virayesh koni : ");
                        int editCode = int.Parse(Console.ReadLine());
                        bool found = false;

                        for (int i = 0; i < lib.BookCount; i++)
                        {
                            if (lib.Books[i].GetCode() == editCode)
                            {
                                lib.Books[i].EditBook();
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                            Console.WriteLine("Ketab peyda nashod.");
                        break;

                    case 4:
                        Member newMember = new Member(0, "", "");
                        newMember.RegisterMember();
                        lib.RegisterMember(newMember);
                        break;

                    case 5:
                        Console.Write("Name Ketab baraye jostojo : ");
                        string searchName = Console.ReadLine();
                        Book result = lib.SearchBook(searchName);

                        if (result != null)
                            result.ShowBook();
                        else
                            Console.WriteLine("Ketab peyda nashod.");
                        break;

                    case 6:
                        Console.Write("Code Ketab : ");
                        int borrowBookCode = int.Parse(Console.ReadLine());
                        Console.Write("Code Ozv : ");
                        int borrowMemberCode = int.Parse(Console.ReadLine());
                        lib.BorrowBook(borrowBookCode, borrowMemberCode);
                        break;

                    case 7:
                        Console.Write("Code Ketab baraye bazgardandan : ");
                        int returnCode = int.Parse(Console.ReadLine());
                        lib.ReturnBook(returnCode);
                        break;

                    case 8:
                        lib.ShowShelves();
                        break;

                    case 9:
                        Report report = new Report();
                        report.FinalReport(lib);
                        break;

                    case 0:
                        Console.WriteLine("Khoda hafez!");
                        break;

                    default:
                        Console.WriteLine("Entekhab eshtebah bood.");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("Baraye edame Enter bezan...");
                    Console.ReadLine();
                }

            } while (choice != 0);

            Console.ReadKey();
        }
    }
}
