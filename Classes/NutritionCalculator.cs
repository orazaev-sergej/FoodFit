using FoodFit.Interfaces;

namespace FoodFit.Classes
{
    internal class NutritionCalculator : INutritionCalculator
    {
        public (double, double, double) CalculateDailyNutrition(IUserInput userInput)
        {
            // Белки: 1.8г * вес, Жиры: 0.9г * вес, Углеводы: 2.5г * вес
            return (1.8 * userInput.GetWeight(), 0.9 * userInput.GetWeight(), 2.5 * userInput.GetWeight());
        }
    }
}