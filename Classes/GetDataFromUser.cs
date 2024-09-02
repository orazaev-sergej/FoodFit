using FoodFit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFit.Classes
{
    internal class GetDataFromUser
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private int Height { get; set; }
        private int Weight { get; set; }
        private Gender Gender { get; set; }

        public void GetData()
        {
            Console.WriteLine("Введите ваше имя: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост: ");
            Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес: ");
            Weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифры вашего пола. 1 - муж, 2 - жен");
            switch (Console.ReadLine())
            {
                case "1": 
                    Gender = Gender.Male; 
                    break;
                case "2":
                    Gender = Gender.Female;
                    break;
                default:
                    Gender = Gender.Undefined;
                    break;
            }
        }

        public GetDataFromUser() { }
    }
}
