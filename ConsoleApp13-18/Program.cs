using System;

namespace ConsoleApp13_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в списке");
            int listCount = Int32.Parse(Console.ReadLine());
            MyList<int> mylist = new MyList<int>(listCount);
            mylist[listCount] = 12;
            while (true)
            {
                Console.WriteLine("Выберите операцию: \n1.Общее количество элементов \n2.Добавить элемент \n3.Вывести один элемент по индексу \n4.Вывести все элементы");
                int operation = Int32.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Емкость списка: {0} элемент(-ов)", mylist.Capacity);
                        Console.WriteLine("Список фактически содержит: {0} элемент(-ов)", mylist.Count);
                        break;
                    case 2:
                        Console.WriteLine("Введите значение элемента: ");
                        int newItem = Int32.Parse(Console.ReadLine());
                        mylist.Add(newItem);
                        break;
                    case 3:
                        Console.WriteLine("Введите индекс элемента: ");
                        int itemIndex = Int32.Parse(Console.ReadLine());
                        int result = mylist[itemIndex];
                        Console.WriteLine("Элемент № {0} - {1}", itemIndex, result);
                        break;
                    case 4:
                        for (int i = 0; i < mylist.Count; i++)
                        {
                            Console.WriteLine("Элемент № {0} - {1}", i, mylist[i]);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
