using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme05ConsoleApp
{
    class Program
    {
        static string[] SplitStringIntoWords(string inputString)
        {
           string[] resultArray = inputString.Split(' ');
           return resultArray;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Разделение строки на слова");
            Console.WriteLine("Введите длинное предложение:");

            string userString = Console.ReadLine();
            SplitStringIntoWords(userString);
        }
    }
}
