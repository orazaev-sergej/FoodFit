using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FoodFit.Classes
{
    public class SaveData
    {
        readonly string FileName = "TEST.TXT";
        readonly UserInput UserInput;
        readonly NutritionCalculator Nutrition;

        private void ExportDataToFile(string FileName)
        {
            string data = $"Имя: {UserInput.GetUsername()}\nВозраст: {UserInput.GetAge()}\n" +
                $"Рост: {UserInput.GetHeight()} см\nВес: {UserInput.GetWeight()} кг\nКалории: {Nutrition.GetDailyCalories()}\n" +
                $"Белки: {Nutrition.GetProteins()}г\nЖиры: {Nutrition.GetFats()}г\nУглеводы: {Nutrition.GetCarbohydrates()}г";
            File.WriteAllText(FileName, data);
        }

        public void SaveToFile() => ExportDataToFile(FileName);
    }
}
