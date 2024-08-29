using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFit.Interfaces
{
    internal interface ICalorieCalculator
    {
        double CalculateDailyCalories(IUserInput userInput);
    }
}
