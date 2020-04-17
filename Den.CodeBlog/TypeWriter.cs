using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Den.CodeBlog
{
    /// <summary>
    /// Печатная машинка
    /// </summary>
    class TypeWriter
    {
        /// <summary>
        /// Пустой конструктор по стандарту
        /// </summary>
        public TypeWriter() { } // и тут я ушел в адскую боль глубочайшего понимания масива и класса, страстным осонанием что уже 3 часа ночи и ещё не все сделал

        /// <summary>
        /// Коструктор печатной машинки. 
        /// </summary>
        /// <param name="arrayText">Предложения</param>
        public TypeWriter(string[] arrayTexts)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // Цикл разбивает текст на слова
            foreach (var words in arrayTexts)
            {
                // Цикл разбивает слова на буквы
                foreach (var letters in words)
                {
                    Console.Write(letters); // Выводи буквы
                    Thread.Sleep(200); // Таймер для вывода каждой буквы
                }

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
        }





        
    }
}
