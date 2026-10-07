using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace پروژه_پایانی___کتابخونه__
{
    class Member
    {
        public int Code;
        public string Name;
        public string Phone;

        public Member(int code,string name,string phone) 
        {
            Code = code;
            Name = name;
            Phone = phone;
        }

        public int GetCode()
        {
            return Code;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetPhone()
        {
            return Phone;
        }

        public void RegisterMember() 
        {
            Console.Write("Member Code : ");
            Code = int.Parse(Console.ReadLine());
            Console.Write("Member Name : ");
            Name = Console.ReadLine();
            Console.Write("Member Phone : ");
            Phone = Console.ReadLine();

            Console.WriteLine("Ozv Ba Movafaghiat Sabt Shod.");
        }

        public void EditMember()
        {
            Console.Write("Member Name jadid : ");
            Name = Console.ReadLine();

            Console.Write("Member Phone jadid : ");
            Phone = Console.ReadLine();

            Console.WriteLine("Etelaat Ozv Ba Movafaghiat Virayesh Shod.");
        }

        public void ShowMember()
        {
            Console.WriteLine("Member Code : " + Code);
            Console.WriteLine("Member Name : " + Name);
            Console.WriteLine("Member Phone : " + Phone);
        }
    }
}
