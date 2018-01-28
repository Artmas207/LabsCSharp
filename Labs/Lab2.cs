using System;

namespace Labs
{
    public class Lab2
    {
        public static void init()
        {
            int numbersOfLines = int.Parse(Console.ReadLine());
            string[] stringArray = new string[numbersOfLines];

            Console.WriteLine("Enter " + numbersOfLines + " strings");
            for (int i = 0; i < numbersOfLines; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            
            string[] sortedStringArray = new string[numbersOfLines];
            for (int i = 0; i < numbersOfLines; i++)
            {
                int s = FindShortestString(stringArray);
                
                sortedStringArray[i] = stringArray[s];
                stringArray[s] = String.Empty;
            }

            for (int i = 0; i < numbersOfLines; i++)
            {
                Console.WriteLine(sortedStringArray[i]);
            }
        }

        private static int FindShortestString(string[] stringArray)
        {
            string shortestString = "";
            int shortestStringSize = int.MaxValue;
            int shortestStringNumber = 0;

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length < shortestStringSize && stringArray[i] != String.Empty)
                {
                    shortestString = stringArray[i];
                    shortestStringSize = shortestString.Length;
                    shortestStringNumber = i;
                }
            }

            return shortestStringNumber;
        }
    }
}