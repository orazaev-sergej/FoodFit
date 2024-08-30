namespace FoodFit.Interfaces
{
    internal interface ICalorieCalculator
    {
        double CalculateDailyCalories(IUserInput userInput);
    }
}
