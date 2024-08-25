using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОпределениеВысокосногоГода
{
    internal class Program
    {
        static void Main(string[] args)
        {
            again:
            Console.WriteLine("Введите год для определения его високосности");
            if (Int32.TryParse(Console.ReadLine(), out int value))
            {
                if (OpredelenieGoda(value))
                {
                    Console.WriteLine("Год високосный");
                }
                else
                {
                    Console.WriteLine("Год не високосный");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка, попробуйте ещё раз");
                goto again;
            }
        }
        private static bool OpredelenieGoda(int god)
        {
            if((god% 4 == 0 && !(god % 100 == 0)) || god % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
