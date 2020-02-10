using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string number = Console.ReadLine();

            if (ulong.TryParse(number, out ulong inputValue))
            {
                char[] arr = number.ToCharArray();
                Console.Write("\nВведенное число наоборот: ");
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    Console.Write(arr[i]);
                }
            }
            else
            {
                Console.WriteLine("Значение введено неверно.");
            }
            Console.ReadKey(true);
        }
    }
}