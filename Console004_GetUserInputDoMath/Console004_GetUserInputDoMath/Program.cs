using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console004_GetUserInputDoMath
{
//    “The Seven Social Sins are:

//      -Wealth without work.
//      -Pleasure without conscience.
//      -Knowledge without character.
//      -Commerce without morality.
//      -Science without humanity.
//      -Worship without sacrifice.
//      -Politics without principle.
    class Program
    {
        
        static void Main(string[] args)
        { //Task "What is the sum of 21 and 34?" --> For a user entry like this this small program 
            //should do a basic integer math of 21 + 34 = 55.

           string[] userWords = GetUserInput(); // split the user input into words
           int[] userNumbers = SelectNumbers(userWords); // get the numbers from the user inputs
           DoMath(userWords, userNumbers); // do simple math based on user numbers and math expression...

           Console.ReadLine();
        }// end main

        private static int[] SelectNumbers(string[] userWords)
        {
            int[] userNumbers = new int[2]; // get the numeric values into another array.
            int index = 0;
            for (int i = 0; i < userWords.Length; i++)
            {
                bool isNumber = int.TryParse(userWords[i], out userNumbers[index]);
                if (isNumber)
                {
                    Console.WriteLine($"Your entry {index + 1}.number...: {userNumbers[index]}");
                    index++;
                }
            }
            return userNumbers;
        }// end method

        private static void DoMath(string[] userWords, int[] userNumbers)
        {
            Console.WriteLine();
            if (userWords.Contains("sum"))
            {
                Console.WriteLine("based on your entry the program will do summation.. ");
                Console.Write($"Result :... {userNumbers[0]} + {userNumbers[1]} = ");
                Console.WriteLine((userNumbers[0] + userNumbers[1]));
            }
            else if (userWords.Contains("subtract"))
            {
                Console.WriteLine("based on your entry the program will do subtraction... ");
                Console.Write($"Result :.... {userNumbers[0]} - {userNumbers[1]} = ");
                Console.WriteLine((userNumbers[0] - userNumbers[1]));
            }
            else if (userWords.Contains("multiply"))
            {
                Console.WriteLine("based on your entry the program will do multiplication... ");
                Console.Write($"Result :... {userNumbers[0]} x {userNumbers[1]} = ");
                Console.WriteLine((userNumbers[0] * userNumbers[1]));
            }
            else if (userWords.Contains("divide"))
            {
                Console.WriteLine("based on your entry the program will do division... ");
                Console.Write($"Result :... {userNumbers[0]} / {userNumbers[1]} = ");
                Console.WriteLine((userNumbers[0] / userNumbers[1]));
            }
            else
            {
                Console.WriteLine("Your entry does not have any recognizable math expression..... ");
            }
        }// end method

        private static string[] GetUserInput()
        {
            Console.WriteLine("Enter an expression including simple integer math(eg. \"sum 4 and 5\" or \"divide 423 by 12\" etc. ....: ");
            Console.WriteLine("----------------------------------------------------------------");
            string userInput = Console.ReadLine();

            while (userInput.Length == 0)
            {
                Console.WriteLine("Not a valid entry...!! Please retry...");
                userInput = Console.ReadLine();
            }
            
          Console.WriteLine("----------------------------------------------------------------");
                
          userInput = userInput.Trim();// get rid of unnecessary empty spaces..
          Console.WriteLine("----------------------------------------------------------------");
          Console.WriteLine("Your entry has the following words..");//for edu purposes we're splitting the user entry into words.
          string[] userWords = userInput.Split(' ');
            
            for (int i = 0; i < userWords.Length; i++)
            {
                Console.WriteLine(userWords[i]); // create an array for the words.
            }
            Console.WriteLine("----------------------------------------------------------------");
            
            return userWords;
        }// end method
    }// end class
}// end namespace
