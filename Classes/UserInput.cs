using FoodFit.Interfaces;

namespace FoodFit.Classes
{
    public class UserInput : IUserInput
    {
        private string Username;
        private int Age;
        private int Height;
        private int Weight;
        private Gender Gender;
        private int ActivityLevel;

        private UserInput(string username, int age, int height, int weight, Gender gender, int activityLevel)
        {
            Username = username;
            Age = age;
            Height = height;
            Weight = weight;
            Gender = gender;
            ActivityLevel = activityLevel;
        }

        public string GetUsername() => Username;
        public int GetAge() => Age;
        public Gender GetGender() => Gender;
        public int GetHeight() => Height;
        public int GetWeight() => Weight;
        public int GetActivityLevel() => ActivityLevel;
    }
}
