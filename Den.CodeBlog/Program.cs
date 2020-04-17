using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Den.CodeBlog
{
    
    class Program
    {
        static void Main(string[] args)
        {

            TypeWriter typeWriter = new TypeWriter(new []{
                 "Проснись, Ильюх...",
                 "Матрица нуждаеться в тебе...",
                 "Следуй за кроликом.",
                 "Тук, тук, Илья."
                });

            

            Console.ReadLine();
        }
    
    }
}
