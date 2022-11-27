using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Tasks
    {
        static void Test()
        {
            Task1();
            Task2();
            Task3();
        }

        static void Task1()
        {
            //1.Разработайте приложение, которое будет находить минимальное и максимальное значение в двумерном массиве.
            Console.Clear();
            int[,] arr = new int[3, 3];
            Console.Write("Enter the first line of the array:  ");
            for (int i = 0; i < 3; i++)
            {
                arr[0, i] = Convert.ToInt32(Console.ReadKey().KeyChar - '0');
                if (i != 2)
                    Console.Write(", ");
            }
            Console.Write("\nEnter the second line of the array: ");
            for (int i = 0; i < 3; i++)
            {
                arr[1, i] = Convert.ToInt32(Console.ReadKey().KeyChar - '0');
                if (i != 2)
                    Console.Write(", ");
            }
            Console.Write("\nEnter the third line of the array:  ");
            for (int i = 0; i < 3; i++)
            {
                arr[2, i] = Convert.ToInt32(Console.ReadKey().KeyChar - '0');
                if (i != 2)
                    Console.Write(", ");
            }
            int min = arr[0, 0];
            int max = arr[0, 0];
            foreach (int i in arr)
            {
                if (min > i)
                    min = i;
                if (max < i)
                    max = i;
            }
            Console.Write($"\n\nMaximum: {max}");
            Console.Write($"\nMaximum: {min}");
            Console.Write("\n\n[Press any key to continue]");
            Console.ReadKey();
        }

        static void Task2()
        {
            //2.Пользователь вводит предложение с клавиатуры. Вам необходимо подсчитать количество слов в нём.
            Console.Clear();
            Console.Write("Enter the sentence: ");
            string str = Console.ReadLine();
            Console.Write($"Number of words: {str.Split(' ').Length}");
            Console.Write("\n\n[Press any key to continue]");
            Console.ReadKey();
        }

        static void Task3()
        {
            //3.Пользователь вводит с клавиатуры предложение. Приложение должно посчитать количество гласных букв в нём.
            Console.Clear();
            Console.Write("Enter the sentence: ");
            string str = Console.ReadLine();
            int count = 0;
            string vowels = Convert.ToString("aeioyuAEIOYU");
            foreach (var i in str)
                if (vowels.Contains(i))
                    count++;
            Console.Write($"Number of vowels: {count}");
            Console.Write("\n\n[Press any key to continue]");
            Console.ReadKey();
        }
    }
}