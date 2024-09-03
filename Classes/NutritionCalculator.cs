using FoodFit.Interfaces;
using System.Xml.Linq;

namespace FoodFit.Classes
{
    public class NutritionCalculator : INutritionCalculator
    {
        private double DailyCalories;
        private double proteins;
        private double fats;
        private double carbohydrates;

        public void CalculateDailyNutrition(IUserInput userInput)
        {
            int height = userInput.GetHeight();
            int weight = userInput.GetWeight();
            int age = userInput.GetAge();
            Gender gender = userInput.GetGender();
            double activityLevel = userInput.GetActivityLevel();

            // Базовая метаболическая скорость (BMR)
            if (gender == Gender.Male)
            {
                DailyCalories = 88 + (13 * weight) +
                    (5 * height) - (5 * age);
            }
            else
            {
                DailyCalories = 448 + (9 * weight) +
                    (3 * height) - (4 * age);
            }
            //Корректируем на уровень активности
            DailyCalories *= (int)activityLevel;

            CalculateProteins(weight);
            CalculateFats(weight);
            CalculateCarbohydrates(weight);
        }

        private void CalculateProteins(int weight) => proteins = weight * 1.8;
        private void CalculateFats(int weight) => fats = weight * 0.9;
        private void CalculateCarbohydrates(int weight) => carbohydrates = weight * 2.5;

        public double GetProteins() => proteins;
        public double GetFats() => fats;
        public double GetCarbohydrates() => carbohydrates;
        public double GetDailyCalories() => DailyCalories;
    }
}