using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.DudkovIE.Sprint0.Task1.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            
            Console.WriteLine("Введите свое имя");
            string Name;
            Name = Console.ReadLine();

            Console.WriteLine("Введите свой возраст");
            int age;
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Здравствуйте, меня зовут: " + Name +  " " + "Мой возраст: " + age);

        }
    }
}
