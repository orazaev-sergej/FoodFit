using Xunit;
using FoodFit.Classes;
using FoodFit.Interfaces;

public class NutritionCalculatorTests
{
    [Fact]
    public void CalculateDailyNutrition_CalculatesCorrectCalories_ForMale()
    {
        // Arrange
        var userInput = new UserInput("John", 25, 180, 70, Gender.Male, 1.2);
        var calculator = new NutritionCalculator();

        // Act
        calculator.CalculateDailyNutrition(userInput);
        int calories = calculator.GetDailyCalories();

        // Assert
        int expectedCalories = (int)((88 + (13 * 70) + (5 * 180) - (5 * 25)) * 1.2);
        Assert.Equal(expectedCalories, calories);
    }
}