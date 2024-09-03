﻿using FoodFit.Interfaces;
using System.Xml.Linq;

namespace FoodFit.Classes
{
    public class NutritionCalculator : INutritionCalculator
    {
        private int DailyCalories;
        private int Proteins;
        private int Fats;
        private int Carbohydrates;

        private static readonly UserInput UserInput = new UserInput();
        private int Height = UserInput.GetHeight();
        private int Weight = UserInput.GetWeight();
        private int Age = UserInput.GetAge();
        private Gender Gender = UserInput.GetGender();

        public void CalculateDailyNutrition(IUserInput userInput)
        {
            // Базовая метаболическая скорость (BMR)
            if (userInput.GetGender() == Gender.Male)
            {
                DailyCalories = 88 + (13 * userInput.GetWeight()) +
                    (5 * userInput.GetHeight()) - (5 * userInput.GetAge());
            }
            else
            {
                DailyCalories = 448 + (9 * userInput.GetWeight()) +
                    (3 * userInput.GetHeight()) - (4 * userInput.GetAge());
            }
            //Корректируем на уровень активности
            DailyCalories *= userInput.GetActivityLevel();

            CalculateProteins();
            CalculateFats();
            CalculateCarbohydrates();
        }

        private void CalculateProteins()
        {
            Proteins = (int)(Weight * 1.8); // 1.8 грамма на кг веса тела
        }

        private void CalculateFats()
        {
            Fats = (int)(Weight * 0.9); // 0.9 грамма на кг веса тела
        }

        private void CalculateCarbohydrates()
        {
            Carbohydrates = (int)(Weight * 2.5); // 2.5 грамма на кг веса тела
        }

        public int GetProteins() => Proteins;
        public int GetFats() => Fats;
        public int GetCarbohydrates() => Carbohydrates;
        public int GetDailyCalories() => DailyCalories;
    }
}