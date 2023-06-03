using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGameDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Persons persons = new Persons();

            

            persons.Xuat();

            Console.WriteLine("ten la " + persons.Name);

            string name2 = persons.anotherName();

            persons.Name = "set ten";

            Console.WriteLine($"ten 2 la {name2}");

            Console.ReadKey();
        }
    }

}