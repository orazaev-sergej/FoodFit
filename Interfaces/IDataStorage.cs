using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFit.Interfaces
{
    internal interface IDataStorage
    {
        void SaveFoodData(IEnumerable<IFoodData> foods);
        IEnumerable<IFoodData> GetFoodData();
    }
}
