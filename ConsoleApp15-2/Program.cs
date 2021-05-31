using System;

namespace ConsoleApp15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] worker = new Worker[2];
            for (int i = 0; i < worker.Length; i++)
            {
                Console.WriteLine("Данные о сотруднике № {0}", i);
                Console.WriteLine("Введите Фамилию: ");
                worker[i].Surname = Console.ReadLine();

                Console.WriteLine("Введите имя: ");
                worker[i].Name = Console.ReadLine();

                Console.WriteLine("Введите должность: ");
                worker[i].Position= Console.ReadLine();

                Console.WriteLine("Год поступления на работу: ");
                string x = Console.ReadLine();
                try
                {
                    worker[i].Year = Convert.ToInt32(x);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Введите год. Пример: 1991");
                    Console.WriteLine(e.Message);
                    //  worker[i].YearOfEmployment = DateTime.Now.Year;
                }

                Console.WriteLine(new string('-', 50));
            }
            for (int i = 0; i < worker.Length; i++)
            {
                Console.WriteLine("Фамилия: {0} Имя: {1} Должность: {2} Год поступления на работу: {3}", worker[i].Surname, worker[i].Name, worker[i].Position, worker[i].Year);
            }
            Console.ReadKey();
        }

    }
}