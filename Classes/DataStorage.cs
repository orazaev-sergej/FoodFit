﻿using FoodFit.Interfaces;
using System.Collections.Generic;

namespace FoodFit.Classes
{
    public class DataStorage : IDataStorage
    {
        private List<IFoodData> foodDataList = new List<IFoodData>();
        public IEnumerable<IFoodData> GetFoodData()
        {
            return foodDataList;
        }

        public void SaveFoodData(IEnumerable<IFoodData> foods)
        {
            foodDataList.AddRange(foods);
        }
    }
}
