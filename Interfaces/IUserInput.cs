namespace FoodFit.Interfaces
{
    enum Sex
    {
        Male,
        Female,
        Undefined
    }
    internal interface IUserInput
    {
        int GetWeight();
        int GetHeight();
        int GetAge();
        Sex GetGender();
    }
}
