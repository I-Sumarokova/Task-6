using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение ");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > resultString.Length)
                    resultString = stringArray[i];
            }

            Console.WriteLine();
            Console.WriteLine("Самое длинное слово - {0}", resultString);
            Console.ReadKey();
        }
    }
}
