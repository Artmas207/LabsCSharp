using System;

namespace Labs
{
    public class Lab3
    {
        public static void init()
        {
            Console.WriteLine("Enter  numbers of strings");
            int numbersOfLines = int.Parse(Console.ReadLine());
            string[] stringArray = new string[numbersOfLines];
            
            Console.WriteLine("Enter " + numbersOfLines + " strings");
            for (int i = 0; i < numbersOfLines; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            int middleLenght = getMiddleLenght(stringArray);
            string[] strnigsLessThenMiddle = new string[numbersOfLines];

            for (int i = 0; i < numbersOfLines; i++)
            {
                if (stringArray[i].Length < middleLenght)
                {
                    strnigsLessThenMiddle[i] = stringArray[i];
                }
            }

            Console.WriteLine("\n\n");
            for (int i = 0; i < numbersOfLines; i++)
            {
                if (strnigsLessThenMiddle[i] != null)
                {
                    Console.WriteLine(strnigsLessThenMiddle[i]);
                    Console.WriteLine(strnigsLessThenMiddle[i].Length);
                }
            }
        }

        private static int getMiddleLenght(string[] stringArray)
        {
            int result = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                result += stringArray[i].Length;
            }

            return result / stringArray.Length;
        }
    }
}