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

        static void PrintWords(string[] inputArray)
        {
            Console.WriteLine($"\nПолучившиеся слова:");

            foreach (var word in inputArray)
            {
               Console.WriteLine(word);
            }
        }

        static string ReversWords(string inputPhrase)
        {
            string[] resultArray=SplitStringIntoWords(inputPhrase);
            string resultString="";
            for (int i = resultArray.Length-1; i >= 0; i--)
            {
                resultString += resultArray[i] + " ";
            }

            return resultString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Разделение строки на слова");
            Console.WriteLine("\nВведите длинное предложение:");

            string userString = Console.ReadLine();
            string[] resultString=SplitStringIntoWords(userString);

            PrintWords(resultString);

            Console.WriteLine("Задание 2. Перестановка слов в предложении");
            Console.WriteLine("\nВведите длинное предложение:");
            string userString2 = Console.ReadLine();

            Console.WriteLine(ReversWords(userString2));

            Console.ReadKey();
        }
    }
}
