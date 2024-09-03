namespace FoodFit.Interfaces
{
    public interface INutritionCalculator
    {
        void CalculateDailyNutrition(IUserInput userInput);
        double GetProteins();
        double GetFats();
        double GetCarbohydrates();
        double GetDailyCalories();
    }
}

