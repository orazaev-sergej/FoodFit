using FoodFit.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace FoodFit.Classes
{
    internal class GetDataFromUser
    {
        private readonly ILogger<GetDataFromUser> _logger;
        private string Name;
        private Gender Gender { get; set; }
        private enum Anthropometry { Age, Height, Weight }
        private Dictionary<Anthropometry, int> UserAnthropometry = new Dictionary<Anthropometry, int>();

        private string[] UserAnthropometryNames = new string[] { "возраст", "рост", "вес" };
        private int[] UserAnthropometryData = new int[3];

        public GetDataFromUser(ILogger<GetDataFromUser> logger)
        {
            _logger = logger;
        }

        public void GetData()
        {
            foreach (var item in Enum.GetValues(typeof(Anthropometry)))
            {
                Console.WriteLine($"Введите ваш {item}");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int value) && value > 1)
                    {
                        UserAnthropometry[(Anthropometry)item] = value;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Неверные данные! Повторите ввод.");
                        _logger.LogError("Ошибка ввода антропометрических данных: {Input}", input);
                    }

                }
            }

            Console.WriteLine("Введите цифры вашего пола. 1 - муж, 2 - жен, 0 - doubleSexual");
            bool validInput = false;
            while (!validInput)
            {
                string genderInput = Console.ReadLine();
                try
                {
                    switch (genderInput)
                    {
                        case "1":
                            Gender = Gender.Male;
                            validInput = true;
                            break;
                        case "2":
                            Gender = Gender.Female;
                            validInput = true;
                            break;
                        case "0":
                            Gender = Gender.Undefined;
                            validInput = true;
                            break;
                        default:
                            Console.WriteLine("Неверные данные! Повторите ввод.");
                            throw new ArgumentException("Неправильный выбор пола");
                    }
                }
                catch (ArgumentException ex)
                {
                    _logger.LogError(ex, "Ошибка при выборе пола: {GenderInput}", genderInput);
                }
            }
        }
    }
}
