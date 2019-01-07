using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CalManV2.DataStorage
{
    public class Storage : Produce, IProduce
    {
        public List<Produce> produces = new List<Produce>();
        public Storage()
        {
            produces.Add(new Produce
            {
                Name = "Cartofi",
                Cal100 = 76.7,
                Cal50 = Cal100 / 2,
                Cal10 = Cal100 / 10
            });
            produces.Add(new Produce
            {
                Name = "Banane",
                Cal100 = 89,
                Cal50 = Cal100 / 2,
                Cal10 = Cal100 / 10
            });
            produces.Add(new Produce
            {
                Name = "Varza",
                Cal100 = 31,
                Cal50 = Cal100 / 2,
                Cal10 = Cal100 / 10
            });
            produces.Add(new Produce
            {
                Name = "Porumb",
                Cal100 = 58,
                Cal50 = Cal100 / 2,
                Cal10 = Cal100 / 10
            });
        }
        public int ListSize => produces.Count;
        public double GetCalories(int ID, int count)
        {
            Produce produce = produces[ID];
            switch(count)
            {
                case 100:
                    return produce.Cal100;
                case 50:
                    return produce.Cal50;
                case 10:
                    return produce.Cal10;
                default:
                    return -1;
            }
        }

        public string GetName(int ID) => produces[ID].Name;
    }
}
