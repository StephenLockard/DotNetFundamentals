using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    class UserInterface
    {
        public void Run()
        {
            // this value causes a loop while true
            bool userContinue = true;

            // instantiate a new Stream object & Repo
            StreamingContent stream = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            // do all of this code while userContinue = true
            do
            {
                /*if statement to check if user response is equal to one of our operations. .ToLower() method
              is used to remove case sensitivity  */
                Console.WriteLine("Select a genre: Horror, Scifi, Fantasy, Comedy, Drama, or Action");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "horror")
                {

                    Console.WriteLine("Would you like to search again? [Yes / No] ");
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
                else if (userInput == "Scifi")
                {

                    Console.WriteLine("Would you like to search again? [Yes / No] ");
                    string userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        userContinue = true;
                        continue;
                    }
                    else userContinue = false;
                }
                else if (userInput == "Fantasy")
                {

                    Console.WriteLine("Would you like to search again? [Yes / No] ");
                    string userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        userContinue = true;
                        continue;
                    }
                    else userContinue = false;
                }
                else if (userInput == "Comedy")
                {

                    Console.WriteLine("Would you like to search again? [Yes / No] ");
                    string userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        userContinue = true;
                        continue;
                    }
                    else userContinue = false;
                }
                else if (userInput == "Drama")
                {

                    Console.WriteLine("Would you like to search again? [Yes / No] ");
                    string userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        userContinue = true;
                        continue;
                    }
                    else userContinue = false;
                }
                else if (userInput == "Action")
                {

                    Console.WriteLine("Would you like to search again? [Yes / No] ");
                    string userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        userContinue = true;
                        continue;
                    }
                    else userContinue = false;
                }
                else
                {

                    Console.WriteLine("Would you like to search again? [Yes / No] ");
                    string userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer == "yes")
                    {
                        userContinue = true;
                        continue;
                    }
                    else userContinue = false;
                }
            }  //ensures loop continues as long as userContinue bool == true
            while (userContinue == true);
        }
    }
}
