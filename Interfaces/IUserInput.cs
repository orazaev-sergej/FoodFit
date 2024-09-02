namespace FoodFit.Interfaces
{
    public enum Gender
    {
        Male,
        Female,
        Undefined
    }
    public interface IUserInput
    {
        int GetWeight();
        int GetHeight();
        int GetAge();
        Gender GetGender();
        int GetActivityLevel();
    }
}
