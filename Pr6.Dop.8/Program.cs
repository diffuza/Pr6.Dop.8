using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            short d = 1; //присвоение локальной переменной d целого типа short

            for (byte i = 0; i < 10; i++) // применение цикла for и присвоение переменной i целого типа "byte"
                Console.Write(i + d++ + "\t"); //вывод строки "..." на экран

            Console.WriteLine(); //Записывает указанные данные с текущим признаком конца строки в стандартный выходной поток.
            d = 1; // присвоение переменной d значения 1.

            for (byte i = 0; i < 10; i++) // применение цикла for и присвоение переменной i целого типа "byte"
                Console.Write(i + ++d + "\t"); //вывод строки "..." на экран

            Console.ReadLine(); //считывание данных
        }

    }
}