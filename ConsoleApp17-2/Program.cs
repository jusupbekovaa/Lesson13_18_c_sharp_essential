using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp17_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>()
                {
                    new Car { Firm = "Audi", Model = "E250", Color = "Black", Year = 2010 },
                    new Car { Firm = "BMW", Model = "X5", Color = "Black", Year = 2020  }
                };
            List<Order> orders = new List<Order>()
                {
                    new Order { AutoModel = "E250", CustomerName = "Клиент 1", CustomerNumber = "123456" },
                    new Order { AutoModel = "X5"  , CustomerName = "Клиент 2", CustomerNumber = "123456"},
                    new Order { AutoModel = "X6"  , CustomerName = "Клиент 3", CustomerNumber = "123456"}
                };

            var orderCar = from car in cars
                           from order in orders
                           where order.AutoModel == car.Model
                           select new
                           {
                               customerName = order.CustomerName,
                               autoFirm = car.Firm,
                               autoModel = car.Model, 
                               autoYear = car.Year
                           }; 

            foreach (var o in orderCar)
                Console.WriteLine($"{o.customerName} - {o.autoFirm} {o.autoModel} - {o.autoYear} года выпуска");

        }
    }
}
