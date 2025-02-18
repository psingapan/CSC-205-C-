﻿using System;

namespace Singapan_CSC205_Week5_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting the user with input
            Console.WriteLine("Please enter a word and I will check if it is in alphabetical order: ");
           
            //assigning user input to the variable, alphabet
            string alphabet = Console.ReadLine();
            
           //Invoking the method with the argument passed in by user input and printing out the final result
            Console.WriteLine(IsAbecedarian(alphabet));
           

        }
        public static bool IsAbecedarian(string alphabet)
        {
            //Assigning the variables here or fields
            int index = 0;
            // Checks if there is an 'a' in the string. If there is an 'a', we will return the index position of that and assign it to firstChar.
            int firstChar = alphabet.IndexOf('a');
            
            //Conditional statement that while the index of 0 remains less than the total length of the user input string...
            while (index < alphabet.Length)
            {
                // another sub conditional statement that checks if the first index position of the string passed is before where the index position of 'a' first appears precedes it,
                // it will return the value of the method as false because since 'a' is the first letter in the alphabet, there can be no other letter that precedes it.
                if (alphabet[index] < firstChar)
                {

                    return false;
                }
               //if it skips the if-conditional statement, we will reassign firstChar (the original index position where 'a' appears) to the next index position of the argument as it traverses through.
                else
                    firstChar = alphabet[index];
                    index++;
            }
            return true;
        }

    }   
}

