namespace FoodFit.Interfaces
{
    internal interface INutritionCalculator
    {
        (double, double, double) CalculateDailyNutrition(IUserInput userInput);
    }
}

