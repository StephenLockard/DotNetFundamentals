using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    class ProgramUI
    {
        StreamingContentRepository repo = new StreamingContentRepository();
        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Make a selection: " +
                    "\n1) Add content to list" +
                    "\n2) Display list" +
                    "\n3) Exit");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        AddContent();
                        break;
                    case 2:
                        DisplayContentList();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Sorry, that isn't a valid input");
                        break;
                }
            }
        }
        private void AddContent()
        {
            StreamingContent newContent = new StreamingContent();

            Console.WriteLine("ContentID");
            newContent.ContentID = Console.ReadLine();
            Console.WriteLine("Rating");
            newContent.Rating = int.Parse(Console.ReadLine());
            Console.WriteLine("Genre");
            newContent.Genre = Console.ReadLine();
            Console.WriteLine("Length");
            newContent.Length = float.Parse(Console.ReadLine());
            Console.WriteLine("Is it Mature? [True / False]");
            newContent.IsMature = bool.Parse(Console.ReadLine());

            repo.AppendContentToList(newContent);
        }

        private void DisplayContentList()
        {
            List<StreamingContent> listOfStreamingContent = repo.GetStreamingContentList();

            foreach (StreamingContent content in listOfStreamingContent)
            {
                Console.WriteLine(content.ContentID + " Rating: " + content.Rating + " Genre: " + content.Genre + " Length: " + content.Length + " Mature rating: " + content.IsMature );
            }

            Console.ReadKey();
        }
    }
}
