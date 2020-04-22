using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace SixthVideo.CodeBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получить с консоли значение трех целых чисел
            // Выбрать наибоьшее из трех чисел
            // Вывести на консоль
            // Сравнить число на четность с помощью свич
            // Проверить на размер < 100 с помощью быстрой проверки

            int a, b, c = 0;

            Console.WriteLine("Вам нужно ввести три разных числа:");

            Console.Write("Введите первое число: ");
            a = EvenNumber(Convert.ToInt32(Console.ReadLine()));


            Console.Write("Введите второе число: ");
            b = EvenNumber(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Введите третие число: ");
            c = EvenNumber(Convert.ToInt32(Console.ReadLine()));

            

            Console.Clear();
            Console.WriteLine($"Вы ввели: {a}, {b}, {c}");

            NumberCheck(a, b, c);
            
            Console.ReadLine();
        }

        /// <summary>
        /// Проверка чисел на самое большое
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третие число</param>
        private static void NumberCheck(int a, int b, int c)
        {
            int big = 0;

            if ((a > b) && (a > c)) // логика на боьшое число 
            {
                big = a;
            }
            else if ((b > a) && (b > c))
            {
                big = b;
            }
            else if ((c > a) && (c > b))
            {
                big = c;
            }
            else if((a == b) && (a > c)) // логика на нахождения одинаковых чисел 
            {
                Console.WriteLine("Бро, не вводи дважды одинаковые числа (");
                big = a;
            }
            else if ((b == a) && (b > c)) 
            {
                Console.WriteLine("Бро, не вводи дважды одинаковые числа (");
                big = b;
            }
            else if ((c == a) && (c > b))
            {
                Console.WriteLine("Бро, не вводи дважды одинаковые числа (");
                big = b;
            }
            else if ((b == a) && (b == c)) // логика на все одинаковые числа
            {
                Console.WriteLine("Чертов читер! У тебя не получиться сломать программу!");
                big = b;
            }
            else
            {
                Console.WriteLine("Ты ввел неправильно. Повтори попытку");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Самое большое из них - {big}");

        }

        /// <summary>
        /// Проверка на четное число, которая не превышает больше ста
        /// </summary>
        /// <param name="number">Число на проверку. Больше ста не писать</param>
        /// <returns></returns>
        private static int EvenNumber(int number)
        {
            switch (number % 2 == 0 && number <= 100)
            {
                case true:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Четное число!");
                    Console.WriteLine();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(number >= 100 ? "Ввел больше 100. Так нельзя, дружек" : "Ввел не четную. Введи четное число, пожалуйста)");
                    Console.WriteLine();
                    Console.Write("Введите число: ");
                    number = EvenNumber(Convert.ToInt32(Console.ReadLine()));
                    break;
            }

            Console.ResetColor();
            return number;
        }
    }
}
