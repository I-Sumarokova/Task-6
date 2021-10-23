using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение ");
            string startString = Console.ReadLine();
            startString = startString.Replace(" ", "");
            startString = startString.ToLower( );
            string resultString = "";
            
            for (int i = startString.Length - 1; i >= 0; i--)
            {
                resultString += startString[i];
            }

            Console.WriteLine();
            if (resultString == startString)
            {
                Console.WriteLine("Введенная строка - палиндром");
            }
            else
            {
                Console.WriteLine("Введенная строка - не палиндром");
            }
           
            Console.ReadKey();
        }
    }
}