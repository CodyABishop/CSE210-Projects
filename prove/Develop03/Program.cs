using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        Scripture workingScrip;
        bool keepRunningMenu = true;
        string chapter = "Timothy 4"; //Chapter
        string text = "Now the Spirit speaketh expressly, that in the latter times some shall depart from the faith, giving heed to seducing spirits, and doctrines of devils;~|~Speaking lies in hypocrisy; having their conscience seared with a hot iron;~|~Forbidding to marry, and commanding to abstain from meats, which God hath created to be received with thanksgiving of them which believe and know the truth.";   //Verse texts, seperated by ~|~
        int startVerse = 1; //First verse
        int endVerse = 3;   // Last verse
        workingScrip = new Scripture(chapter, startVerse, endVerse, text);

        while (keepRunningMenu)
        {
            Console.Clear();
            Console.WriteLine("Testing Scrip Display");
            workingScrip.Display();
            string userInput = Console.ReadLine();
            if (userInput.Equals("quit"))
            {
                keepRunningMenu = false;
            } else if (workingScrip.HiddenStatus() == true)
            {
                keepRunningMenu = false;
            } else{
                workingScrip.HideRandom();
            }
        }
    }
}

