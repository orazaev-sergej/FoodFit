using Xunit;
using System.IO;
using FoodFit.Classes;
using FoodFit.Interfaces;

public class SaveDataTests
{
    [Fact]
    public void SaveToFile_CreatesCorrectFileContent()
    {
        // Arrange
        var userInput = new UserInput("John", 25, 180, 70, Gender.Male, 1.2);
        var calculator = new NutritionCalculator();
        calculator.CalculateDailyNutrition(userInput);
        var saveData = new SaveData(userInput, calculator);

        // Act
        saveData.SaveToFile();
        var content = File.ReadAllText("TEST.TXT");

        // Assert
        string expectedContent = $"Имя: John\nВозраст: 25\nРост: 180 см\nВес: 70 кг\n" +
                                 $"Калории: {calculator.GetDailyCalories()}\n" +
                                 $"Белки: {calculator.GetProteins()}г\n" +
                                 $"Жиры: {calculator.GetFats()}г\n" +
                                 $"Углеводы: {calculator.GetCarbohydrates()}г";
        Assert.Equal(expectedContent, content);
    }
}