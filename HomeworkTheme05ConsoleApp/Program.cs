using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme05ConsoleApp
{
    class Program
    {
        /// <summary>
        /// Метод, который разбивает строку на отдельные слова, разделитель - пробел
        /// </summary>
        /// <param name="inputString">Введенная пользователем строка</param>
        /// <returns>Массив отдельных слов</returns>
        static string[] SplitStringIntoWords(string inputString)
        {
           string[] resultArray = inputString.Split(' ');
           return resultArray;
        }
        /// <summary>
        /// Метод, который выводит каждое слово в отдельной строке
        /// </summary>
        /// <param name="inputArray">Полученный массив слов</param>
        static void PrintWords(string[] inputArray)
        {
            Console.WriteLine($"\nПолучившиеся слова:");

            foreach (var word in inputArray)
            {
               Console.WriteLine(word);
            }
        }
        /// <summary>
        /// Метод, который меняет слова в предложении местами (в обратной последовательности)
        /// </summary>
        /// <param name="inputPhrase">Введенная пользователем строка</param>
        /// <returns>Строка, в обратной последовательности</returns>
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
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Разделение строки на слова");
            Console.WriteLine("\nВведите длинное предложение:");

            string userString = Console.ReadLine();
            string[] resultString=SplitStringIntoWords(userString); //Вызываем метод SplitStringIntoWords(userString) и сохраняем результат в массиве

            PrintWords(resultString); //Вызываем метод PrintWords(resultString)

            Console.WriteLine("Задание 2. Перестановка слов в предложении");
            Console.WriteLine("\nВведите длинное предложение:");
            string userString2 = Console.ReadLine();

            Console.WriteLine(ReversWords(userString2)); //Вызываем метод ReversWords(userString2)

            Console.ReadKey();
        }
    }
}
