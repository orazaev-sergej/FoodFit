namespace FoodFit.Classes
{
    internal class FoodData : IFoodData
    {
        private double calories;
        private double proteins;
        private double fats;
        private double carbohydrates;

        FoodData (double calories, double proteins, double fats, double carbohydrates)
        {
            this.calories = calories;
            this.proteins = proteins;
            this.fats = fats;
            this.carbohydrates = carbohydrates;
        }

        public double GetCalories() => calories;
        public double GetCarbohydrates() => carbohydrates;
        public double GetFats() => fats;
        public double GetProteins() => proteins;
    }
}
