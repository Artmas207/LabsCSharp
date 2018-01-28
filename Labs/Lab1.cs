using System;
using System.Collections;

namespace Labs
{
    public class Lab1
    {
        private string[] stringArray;

        public void init()
        {
            Console.WriteLine("Enter numder of words");
            int numberOfLines = int.Parse(Console.ReadLine());

            stringArray = new string[numberOfLines];
            
            Console.WriteLine("Enter " + numberOfLines + " strings");
            for (int i = 0; i < numberOfLines; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            
            int shortestStringSize = Int32.MaxValue;
            string shortestString = "";
            for (int i = 0; i < numberOfLines; i++)
            {
                if (stringArray[i].Length < shortestStringSize)
                {
                    shortestString = stringArray[i];
                    shortestStringSize = stringArray[i].Length;
                }
            }
            
            Console.WriteLine(shortestString);
            Console.WriteLine("Length is " + shortestStringSize);
        }
    }
}