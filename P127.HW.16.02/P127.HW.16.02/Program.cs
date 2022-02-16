using System;

namespace P127.HW._16._02
{
    class Program
    {
        static void Main(string[] args)
        {
          /*   Task:
           Student classi yaradirsiz.Name, Surname, Group, Point,isGraduated(mezun olub olmadigi ile bagli boolean bir type olacaq) 
           field - leri olacaq.Student classindan instance alindigi zaman birbasha student field-lerinin deyerleri dinamik sekilde teyin olunsun.
           Studentin Ad ve soyadini geriye qaytaran bir method yazirsiz.
           Studentin butun deyerlerini geriye qaytaran bir method yazirsiz. Eger mezun olubsa butun deyerlerden sonra bu telebe
           mezun olub deye yazilsin, eger mezun olmayibsa mezun olmadigi ile bagli bir melumat yazilsin
           Studentin balini artirmaq ucun novbeti imtahana girib gire bilmeyeceyi ile bagli bir melumat geriye qaytaran method yazirsiz.
           Bali 80 - den yuxari telebeler ikinci imtahana gire biler, asagi olan telebeler ise gire bilmezler*/




            Student student = new Student("Emin","Eyvazov","P127",79,true);
            Console.WriteLine(student.FullName());
            student.GetInfo();
            student.Exam(81);
        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool isGraduated;

        public Student(string name, string surname, string group, byte point, bool graduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            isGraduated = graduated;
        }
        public string FullName()
        {
            return $"{Name} {Surname}";
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nGroup: {Group}\nPoint: {Point}");
            if (isGraduated)
            {
                Console.WriteLine("Graduated: Mezun");

            }
            else
            {
                Console.WriteLine("Graduated: Mezun deyil");
            }
        }
        public void Exam(byte point)
        {
            if (point>=80)
            {
                Console.WriteLine("Novbeti imtahana gireceksiniz");
            }
            else
            {
                Console.WriteLine("Kesildiniz");
            }
        }
     }




    
}
