using System;

namespace ConsoleApp16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House { City = "Bishkek", Cost = 12230 };
            House house2 = (House)house1.Clone();
            House house3 = (House)house1.DeepClone();
            Console.WriteLine(house1.City);
            Console.WriteLine(house2.City);
            Console.WriteLine(house3.City);
        }
    }
}
