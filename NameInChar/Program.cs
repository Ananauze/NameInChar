using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            char rectangleSymbol;
            string name = "";
            string rectangleLine = "";
            
            Console.Write("Введите Ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите символ для отрисовки прямоугольника: ");
            rectangleSymbol = Convert.ToChar(Console.ReadLine());

            int nameLenght = name.Length;
            string fullRectangleLine = rectangleSymbol + name + rectangleSymbol;

            for (int i = 1; i <= fullRectangleLine.Length; i++) 
            {
                rectangleLine += rectangleSymbol;
            }
           
            Console.Clear();
            Console.WriteLine(name);
            Console.WriteLine($"\n {rectangleSymbol} \n");
            Console.WriteLine($"{rectangleLine}");
            Console.WriteLine($"{rectangleSymbol}{name}{rectangleSymbol}");
            Console.WriteLine($"{rectangleLine} \n");
            Console.ReadLine();
        }
    }
}
