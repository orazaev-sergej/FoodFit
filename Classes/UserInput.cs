
using FoodFit.Interfaces;

namespace FoodFit.Classes
{
    public class UserInput : IUserInput
    {
        private int Age;
        private int Height;
        private int Weight;
        private Sex Gender;

        public UserInput(int age, int height, int weight, Sex gender)
        {
            Age = age;
            Height = height;
            Weight = weight;
            Gender = gender;
        }

        public int GetAge() => Age;
        public Sex GetGender() => Gender;
        public int GetHeight() => Height;
        public int GetWeight() => Weight;
    }
}
