using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17_2
{
    class Order
    {
        string customerName;
        string phoneNumber;
        string autoModel;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string CustomerNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string AutoModel
        {
            get { return autoModel; }
            set { autoModel = value; }
        }
        public void GetInfo(Order order)
        {
            string customerResult = "Имя клиента: "+order.CustomerName + " Номер телефона: " + order.CustomerNumber +  " Модель автомобиля: " + order.AutoModel;
            Console.WriteLine(customerResult);
        }

    }
}
