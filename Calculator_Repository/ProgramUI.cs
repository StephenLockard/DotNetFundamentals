using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Repository
{
    class ProgramUI
    {
        public void Run()
        {
            // this value creates a loop while true
            bool userContinue = true;

            // instantiate a new Calculator object
            Calculator calculator = new Calculator();

            // do all of this code while userContinue = true
            do
            {
                /* Prompt user for two inputs, assign those inputs to a variable. If both inputs are NOT
                   of type "double" then loop back to prompting the user */
                Console.WriteLine("Function to calculate two numbers with varying operations:\n -------------------");
                Console.WriteLine("Enter a number: ");
                bool isDouble = double.TryParse(Console.ReadLine(), out double numberOne);

                Console.WriteLine("Enter another number: ");
                bool isDoubleTwo = double.TryParse(Console.ReadLine(), out double numberTwo);

                // executes code if both user inputs are valid "double" type
                if (isDouble == true && isDoubleTwo == true)
                {

                    /*if statement to check if user response is equal to one of our operations. .ToLower() method
                      is used to remove case sensitivity  */
                    Console.WriteLine("Select an operation: Add, Subtract, Divide, Multiply, Modulus, Exponent: ");
                    string userInput = Console.ReadLine().ToLower();
                    if (userInput == "add")
                    {
                        Console.WriteLine("Your answer is : {0}", calculator.additionResult(numberOne, numberTwo));
                        Console.WriteLine("Would you like to do another calculation? [Yes / No]");
                        string userAnswer = Console.ReadLine().ToLower();

                        /* If statement allowing the user to do more calculations, or end program by setting 
                           value of userContinue bool. */
                        if (userAnswer == "yes")
                        {
                            userContinue = true;
                            continue;
                        }
                        else userContinue = false;
                    }
                    else if (userInput == "subtract")
                    {
                        Console.WriteLine("Your answer is : {0}", calculator.subtractionResult(numberOne, numberTwo));
                        Console.WriteLine("Would you like to do another calculation? [Yes / No]");
                        string userAnswer = Console.ReadLine().ToLower();
                        if (userAnswer == "yes")
                        {
                            Console.Clear();
                            userContinue = true;
                            continue;
                        }
                        else userContinue = false;
                    }
                    else if (userInput == "divide")
                    {
                        Console.WriteLine("Your answer is : {0}", calculator.divisionResult(numberOne, numberTwo));
                        Console.WriteLine("Would you like to do another calculation? [Yes / No]");
                        string userAnswer = Console.ReadLine().ToLower();
                        if (userAnswer == "yes")
                        {
                            Console.Clear();
                            userContinue = true;
                            continue;
                        }
                        else userContinue = false;
                    }
                    else if (userInput == "multiply")
                    {
                        Console.WriteLine("Your answer is : {0}", calculator.multiplicationResult(numberOne, numberTwo));
                        Console.WriteLine("Would you like to do another calculation? [Yes / No]");
                        string userAnswer = Console.ReadLine().ToLower();
                        if (userAnswer == "yes")
                        {
                            Console.Clear();
                            userContinue = true;
                            continue;
                        }
                        else userContinue = false;
                    }
                    else if (userInput == "modulus")
                    {
                        Console.WriteLine("Your answer is : {0}", calculator.modulusResult(numberOne, numberTwo));
                        Console.WriteLine("Would you like to do another calculation? [Yes / No]");
                        string userAnswer = Console.ReadLine().ToLower();
                        if (userAnswer == "yes")
                        {
                            Console.Clear();
                            userContinue = true;
                            continue;
                        }
                        else userContinue = false;
                    }
                    else if (userInput == "exponent")
                    {
                        Console.WriteLine("Your answer is : {0}", calculator.exponentResult(numberOne, numberTwo));
                        Console.WriteLine("Would you like to do another calculation? [Yes / No]");
                        string userAnswer = Console.ReadLine().ToLower();
                        if (userAnswer == "yes")
                        {
                            Console.Clear();
                            userContinue = true;
                            continue;
                        }
                        else userContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid request (maybe you mispelled it?)");
                        Console.WriteLine("Would you like to do another calculation? [Yes / No]");
                        string userAnswer = Console.ReadLine().ToLower();
                        if (userAnswer == "yes")
                        {
                            Console.Clear();
                            userContinue = true;
                            continue;
                        }
                        else userContinue = false;
                    }
                }
                else
                    userContinue = true;
            }

            //ensures loop continues as long as userContinue bool == true
            while (userContinue == true);
        }
    }
}
