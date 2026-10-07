using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace پروژه_پایانی___کتابخونه__
{
    class Library
    {
        public Book[] Books;
        public int BookCount;

        public Member[] Members;
        public int MemberCount;

        public string[,] Shelves;

        public Library()
        {
            Books = new Book[100];
            BookCount = 0;
            Members = new Member[100];
            MemberCount = 0;
            Shelves = new string[5, 10];
        }

        public void AddBook(Book b)
        {
            if (BookCount >= Books.Length)
            {
                Console.WriteLine("Zarfiat ketabkhone por shode.");
                return;
            }

            Books[BookCount] = b;
            BookCount++;

            bool jaPeyda = false;

            for (int i = 0; i < 5 && !jaPeyda; i++)
            {
                for (int j = 0; j < 10 && !jaPeyda; j++)
                {
                    if (Shelves[i, j] == null)
                    {
                        Shelves[i, j] = b.GetCode().ToString();
                        jaPeyda = true;
                        Console.WriteLine("Ketab dar Ghafase {0} Jaygah {1} gharar gereft.", i + 1, j + 1);
                    }
                }
            }

            if (!jaPeyda)
                Console.WriteLine("Hame ghafaseha por hastan, ja baraye ketab nabood.");
        }

        public void DeleteBook(int code)
        {
            int index = -1;

            for (int i = 0; i < BookCount; i++)
            {
                if (Books[i].GetCode() == code)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Ketab ba in code peyda nashod.");
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Shelves[i, j] == code.ToString())
                    {
                        Shelves[i, j] = null;
                    }
                }
            }

            Books[index] = null;
            Console.WriteLine("Ketab hazf shod.");
        }

        public Book SearchBook(string name, int index = 0)
        {
            //میتونی با فور هم بنویسی
            if (index >= BookCount)
                return null;

            if (Books[index] != null && Books[index].GetName() == name)
                return Books[index];

            return SearchBook(name, index + 1);
        }

        public void DisplayBooks()
        {
            if (BookCount == 0)
            {
                Console.WriteLine("Hich ketabi dar ketabkhone nist.");
                return;
            }

            for (int i = 0; i < BookCount; i++)
            {
                if (Books[i] != null)
                {
                    Books[i].ShowBook();
                    Console.WriteLine("-------------------");
                }
            }
        }

        public void BorrowBook(int bookCode, int memberCode)
        {
            Book foundBook = null;
            Member foundMember = null;

            for (int i = 0; i < BookCount; i++)
            {
                if (Books[i] != null && Books[i].GetCode() == bookCode)
                {
                    foundBook = Books[i];
                    break;
                }
            }

            for (int i = 0; i < MemberCount; i++)
            {
                if (Members[i].GetCode() == memberCode && Members[i] != null)
                {
                    foundMember = Members[i];
                    break;
                }
            }

            if (foundBook == null)
            {
                Console.WriteLine("Ketab peyda nashod.");
                return;
            }

            if (foundMember == null)
            {
                Console.WriteLine("Ozv peyda nashod.");
                return;
            }

            foundBook.BorrowBook();
        }

        public void ReturnBook(int bookCode)
        {
            Book foundBook = null;

            for (int i = 0; i < BookCount; i++)
            {
                if (Books[i] != null && Books[i].GetCode() == bookCode)
                {
                    foundBook = Books[i];
                    break;
                }
            }

            if (foundBook == null)
            {
                Console.WriteLine("Ketab peyda nashod.");
                return;
            }

            foundBook.ReturnBook();
        }

        public void ShowShelves()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ghafase {0}: ", i + 1);

                for (int j = 0; j < 10; j++)
                {
                    if (Shelves[i, j] == null)
                        Console.Write("[Khali] ");
                    else
                        Console.Write("[{0}] ", Shelves[i, j]);
                }

                Console.WriteLine();
            }
        }

        public void CountBook()
        {
            Console.WriteLine(BookCount);
        }

        public void RegisterMember(Member m)
        {
            if (MemberCount >= Members.Length)
            {
                Console.WriteLine("Zarfiat azaye ketabkhone por shode.");
                return;
            }

            Members[MemberCount] = m;
            MemberCount++;
        }
    }
}
