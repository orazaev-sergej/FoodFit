using FoodFit.Classes;
using FoodFit.Interfaces;
using Xunit;

public class UserInputTests
{
    [Fact]
    public void GetUsername_ReturnsCorrectUsername()
    {
        // Arrange
        var userInput = new UserInput("TestUser", 25, 180, 70, Gender.Male, 3);

        // Act
        string username = userInput.GetUsername();

        // Assert
        Assert.Equal("TestUser", username);
    }
}