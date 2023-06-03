using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameDemo
{
    class Persons
    {
        private string name;
        private int tuoi;

        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Name { get => name; set => name = value; }

        public Persons(string ten = "ten", int tuoi = 10)
        {
            Name = ten;
            this.Tuoi = tuoi;
        }

        public void Xuat()
        { 
            Name = "nguyen van a";
            Tuoi = 3;
            Console.WriteLine($"{Name} tuoi la {Tuoi}");
        }

        public String anotherName()
        {
            return "nguyen B";
        }
    }
}
