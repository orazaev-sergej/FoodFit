namespace FoodFit.Interfaces
{
    public interface INutritionCalculator
    {
        (double, double, double) CalculateDailyNutrition(IUserInput userInput);
    }
}

