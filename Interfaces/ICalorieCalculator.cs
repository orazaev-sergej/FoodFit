namespace FoodFit.Interfaces
{
    public interface ICalorieCalculator
    {
        double CalculateDailyCalories(IUserInput userInput);
    }
}
