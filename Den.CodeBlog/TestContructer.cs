using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den.CodeBlog
{
    /// <summary>
    /// Тестовый класс для пробы конструкторов
    /// </summary>
    class TestContructer
    {
        private string _name;
        private int _age;

        public TestContructer() { }

        /// <summary>
        /// Это тестовый конструктор
        /// </summary>
        /// <param name="name">Пишем имя человека</param>
        public TestContructer(string name)
        {
            _name = name;
        }


        /// <summary>
        /// Второй конструктор
        /// </summary>
        /// <param name="n">Имя человека</param>
        /// <param name="a">Возраст человека</param>
        public TestContructer(string n, int a) : this(n)
        {
            _age = a;
        }

        /// <summary>
        /// Информация о человеке
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"{_name} - {_age}");

            
        }
    }
}
