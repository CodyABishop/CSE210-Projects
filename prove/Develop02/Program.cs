using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();
        bool keepRunningMenu = true;
        while (keepRunningMenu)
        {
            string[] promptsForWriting = {"How has the Lord had a hand in my life today?", "What was the most unexpected event I encountered today?", "Did I do anything I regret today?", "Given the chance, what would I do differently than I did today?", "What have I learned from today's events?"};
            Console.WriteLine("Please select an option.");
            Console.WriteLine("1 New Entry");
            Console.WriteLine("2 Display Journal");
            Console.WriteLine("3 Save to File");
            Console.WriteLine("4 Load from File");
            Console.WriteLine("0 Exit");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            { 
                Random randomGenerator = new Random();
                int promptSelected = randomGenerator.Next(0, (promptsForWriting.Length - 1));
                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._journalTime = theCurrentTime.ToShortDateString();
                newEntry._promptText = promptsForWriting[promptSelected];
                Console.WriteLine(promptsForWriting[promptSelected]);
                Console.WriteLine();
                newEntry._response = Console.ReadLine();
                Console.WriteLine();
                currentJournal._entryList.Add(newEntry);
                Console.WriteLine("Added to Journal.");
                
            } else if (userInput == 2){
                Console.WriteLine("Displaying all entries.");
                currentJournal.Display();
            } else if (userInput == 3){
                Console.WriteLine("Please enter a filename.");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Entry i in currentJournal._entryList)
                    {
                        outputFile.WriteLine(i._journalTime + "~|~" + i._promptText + "~|~" + i._response);
                    }
                }

            } else if (userInput == 4){
                Console.WriteLine("Please enter the filename to load.");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    Entry newEntry = new Entry();
                    string[] parts = line.Split("~|~");
                    newEntry._journalTime = parts[0];
                    newEntry._promptText = parts[1];
                    newEntry._response = parts[2];
                    currentJournal._entryList.Add(newEntry);
                }

            }  else if (userInput == 0){
                Console.WriteLine("Have a nice day.");
                keepRunningMenu = false;
            } else{
                Console.WriteLine("Unkown input. Please select an option by typing an integer from 0 to 4.");
            }
        }
    }
}

