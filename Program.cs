using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace CamelSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konwerter: \n" +
                "Jesli chcesz konwertować camelCase do snake_case wciśnij 1\n" +
                "Jeśli snake_case do camelCase wciśnij 2");

            var number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Podaj zapis w postaci camelCase");
                var value = Console.ReadLine();
                Console.WriteLine(ToSnakeCase(value));
            }
            else if (number == 2)
            {
                Console.WriteLine("Podaj zapis w postaci snake_case");
                var value = Console.ReadLine();
                Console.WriteLine(ToCamelCase(value));
            }
            else
            {
                Console.WriteLine("podano złą liczbę");
            }

            Console.ReadLine();
        }

        public static string ToCamelCase(string value)
        {
            string[] numberList = value.Split(new string[] { "_" }, StringSplitOptions.None);

            string firstText = (numberList[0].ToString()).ToLower();
            string text = null;
            string restText = null;
            for (int i = 1; i < numberList.Length; i++)
            {
                text = (numberList[i].ToString()).ToLower();
                
                var firstLetter = (Char.ToUpper(text[0])).ToString();

                text = firstLetter + text.Remove(0, 1);
                
                restText += text;
                
            }

            return firstText + restText;
        }

        public static string ToSnakeCase(string value)
        {
            
            char[] signs = value.ToCharArray(0, value.Length);
            

            for (int i = 0; i < signs.Length; i++)
            {
                if (Char.IsUpper(signs[i]))
                {
                    value = value.Replace($"{signs[i]}", $"_{signs[i]}");
                }
            }

            value = value.ToLower();

            return value;
        }
    }
}
