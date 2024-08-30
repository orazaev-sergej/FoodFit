namespace FoodFit.Interfaces
{
    public enum Sex
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
        Sex GetGender();
    }
}
