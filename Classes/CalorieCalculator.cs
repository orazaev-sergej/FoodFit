using FoodFit.Interfaces;

namespace FoodFit.Classes
{
    public class CalorieCalculator : ICalorieCalculator
    {
        public double CalculateDailyCalories(IUserInput userInput)
        {
            return 10 * userInput.GetWeight() + 6.25 * userInput.GetHeight() - 5 * userInput.GetAge();
        }
    }
}
