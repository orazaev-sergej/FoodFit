namespace FoodFit.Interfaces
{
    public interface INutritionCalculator
    {
        void CalculateDailyNutrition();
        double GetProteins();
        double GetFats();
        double GetCarbohydrates();
        double GetDailyCalories();
    }
}

