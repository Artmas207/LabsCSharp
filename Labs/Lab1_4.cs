using System;
using System.Text;

namespace Labs
{
    public class Lab1_4
    {
        private static string text;
        private static char userSymbol;

        public static void init()
        {
            text = System.IO.File.ReadAllText(
                "C:\\Users\\Artmas\\RiderProjects\\LABS\\LabsCSharp\\Labs\\Lab1_4_Text.txt");

            Console.WriteLine("Enter number of symbol");
            int numberOfSymbol = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a symbol");
            userSymbol = char.Parse(Console.ReadLine());

            string[] stringArray = text.Split(" ");
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length >= numberOfSymbol)
                {
                    StringBuilder str = new StringBuilder(stringArray[i]);
                    str[numberOfSymbol] = userSymbol;
                    stringArray[i] = str.ToString();
                }
            }

            text = "";
            for (int i = 0; i < stringArray.Length; i++)
            {
                text += stringArray[i] += " ";
            }
            Console.WriteLine(text);
        }
    }
}