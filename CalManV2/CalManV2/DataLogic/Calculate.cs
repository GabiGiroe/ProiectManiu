using System;
using CalManV2.DataStorage;
namespace CalManV2.DataLogic
{
    public class Calculate
    {
        private double inputValue;
        private int size;
        Storage storage = new Storage();
        public Calculate() => size = storage.ListSize;
        public void SetInput(double input) => inputValue = input;
        private int GetID()
        {
            Random random = new Random();
            return random.Next(size);
        }
        private int Substract(int ID, double value)
        {
            if (value > inputValue)
            {
                return -1;
            }
            else
            {
                inputValue -= value;
                return 1 + Substract(ID, value);
            }
        }
        public string Result()
        {
            int ID = GetID();
            string result;
            double calories = storage.GetCalories(ID, 100);
            int multiplier = Substract(ID, calories);
            if (multiplier == -1) return "";
            result = System.Convert.ToString(calories * multiplier) + "g " + storage.GetName(ID) + " ";
            ID = GetID();
            calories = storage.GetCalories(ID, 50);
            multiplier = Substract(ID, calories);
            if (multiplier == -1) return result;
            result += System.Convert.ToString(calories * multiplier) + "g " + storage.GetName(ID) + " ";
            ID = GetID();
            calories = storage.GetCalories(ID, 10);
            multiplier = Substract(ID, calories);
            if (multiplier == -1) return result;
            return result + System.Convert.ToString(calories * multiplier) + "g " + storage.GetName(ID);
        }
    }
}
