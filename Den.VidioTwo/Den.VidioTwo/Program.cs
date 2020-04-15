using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Den.VidioTwo
{
    // Задание: создать консольное приложение с 4 командами, зеленным текстом и эффект печатной машинки 
    //
    // 1. Четыре команады - Done
    // 2. Зеленный текст - Done
    // 3. Эффект печетной машинки - Done
    class Program
    {
        static void Main(string[] args)
        {
            // команды в массиве
            string[] test = new string[4];
            test[0] = "Проснись, Ильюх...";
            test[1] = "Матрица нуждаеться в тебе...";
            test[2] = "Следуй за кроликом.";
            test[3] = "Тук, тук, Илья.";


            for (int i = 0; i < test.Length; i++)
            {
                TypeWriter(test[i]);
                Thread.Sleep(200);
                Console.ReadLine();
                Console.Clear();
            }
            
        }

        // Метод для эффекта печатной машинки
        static void TypeWriter(string t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var ch in t)
            {
                Console.Write(ch);
                Thread.Sleep(200); //
            }
        }


    }
}
