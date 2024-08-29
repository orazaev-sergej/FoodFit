using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        int GetGender();
    }
}
