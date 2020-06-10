using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    class Zdorovie
    {
        private int temp;
        public int Temp
        {
            get
            {
                return temp;
            }
            set
            {
                if (value <= 34)
                   temp = 34;
                else if (value >= 41)
                   temp = 41;               
                else
                    temp = value;
            }
        }
    }

    class Book
    {
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value <= 1940)
                    year = 1940;
                else if (value >= 2020)
                    year = 2020;
                else
                    year = value;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zdorovie hum1 = new Zdorovie();
            hum1.Temp = 45;
            Console.WriteLine("Температура = " + hum1.Temp);
            Console.WriteLine();
            //Задание 1

            Book bk = new Book();
            bk.Year = 2021;
            Console.WriteLine("Год выпуска книги: " + bk.Year);
            Console.ReadKey();
            
            //Задание 2
        }
    }
}
