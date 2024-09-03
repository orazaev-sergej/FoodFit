using Xunit;
using FoodFit;
using FoodFit.Classes;

public class FoodDataTests
{
    [Fact]
    public void GetCalories_ReturnsCorrectValue()
    {
        // Arrange
        var foodData = new FoodData(200, 10, 5, 20);

        // Act
        double calories = foodData.GetCalories();

        // Assert
        Assert.Equal(200, calories);
    }
    [Fact]
    public void GetCarbohydrates_ReturnsCorrectValue()
    {
        // Arrange
        var foodData = new FoodData(200, 10, 5, 20);

        // Act
        double carbohydrates = foodData.GetCarbohydrates();

        // Assert
        Assert.Equal(20, carbohydrates);
    }

    [Fact]
    public void GetFats_ReturnsCorrectValue()
    {
        // Arrange
        var foodData = new FoodData(200, 10, 5, 20);

        // Act
        double fats = foodData.GetFats();

        // Assert
        Assert.Equal(5, fats);
    }

    [Fact]
    public void GetProteins_ReturnsCorrectValue()
    {
        // Arrange
        var foodData = new FoodData(200, 10, 5, 20);

        // Act
        double proteins = foodData.GetProteins();

        // Assert
        Assert.Equal(10, proteins);
    }
}