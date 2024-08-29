using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFit
{
    internal interface IFoodData
    {
        double GetCalories();
        double GetProteins();
        double GetFats();
        double GetCarbohydrates();
    }
}
