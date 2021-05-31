using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16_3
{
    class House: ICloneable
    {
        string city;
        double cost;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public object DeepClone()
        {
            return new House
            {
                City = this.City,
                Cost = this.Cost
            };
        }
    }
}
