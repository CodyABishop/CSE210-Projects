class Program
{
    static void Main(string[] args)
    {
        bool keepRunningMenu = true;
        while (keepRunningMenu) //Simple looping menu.
        {
            Console.WriteLine("Please select an exercise from the list below.");
            Console.WriteLine("1 Breathing Exercise");
            Console.WriteLine("2 Reflecting Exercise");
            Console.WriteLine("3 Listing Exercise");
            Console.WriteLine("0 Exit");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                BreathingActivity brActiv = new BreathingActivity();
                brActiv.StartBreathing();
            } else if (userInput == 2){
                ReflectionActivity reActiv = new ReflectionActivity();
                reActiv.StartReflecting();
            } else if (userInput == 3){
                ListingActivity liActiv = new ListingActivity();
                liActiv.StartListing();
            } else if (userInput == 0){
                Console.WriteLine("Have a nice day.");
                keepRunningMenu = false;
            } else{
                Console.WriteLine("Unkown input. Please select an option by typing an integer from 0 to 3.");
            }
        }
    }
}