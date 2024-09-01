using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2_E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables
            int total = 0;
            //Prompts user to enter a sentence
            Console.Write("Enter a string: ");
            //Converts user input to string and lowers the case to allow comparison
            string inputString = Console.ReadLine().ToLower();
            //Checks each character in string for vowels
            foreach (char c in inputString)
            {
                switch (c)
                {
                    //Go through all vowels stated below and adds to total by 1; breaks when finished comparing all characters in string
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        //When a vowel is found it adds to total
                        total = total + 1;
                        break;
                }
            }
            //Writes output of vowels counted in string
            Console.WriteLine($"The number of vowels in the string is: {total}");
            //Pauses program to allow user to read
            Console.ReadLine();
        }
    }
}
