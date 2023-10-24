class Program
{
    static void Main(string[] args)
    {
        bool keepRunningMenu = true; //Menu control
        int userPoints = 0; //Starting point for points.
        List<Goal> AllGoals = new List<Goal>();   //Keeps track of all goals
        while (keepRunningMenu) //Simple looping menu.
        {
            Console.WriteLine("You're up to " + userPoints + " points! Keep it going!");
            Console.WriteLine("1 View All Goals");
            Console.WriteLine("2 Record an Event");
            Console.WriteLine("3 Create New Goal");
            Console.WriteLine("4 Save Goals");
            Console.WriteLine("5 Load Goals");
            Console.WriteLine("0 Exit");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1) //DISPLAY ALL GOALS
            {
                int goalID = 0; //Instantiates an iterator to keep track of goal id
                foreach (Goal g in AllGoals)
                {                    
                    Console.WriteLine("Goal #" + goalID++);
                    g.Display(); //Prints each goal
                }
            } //END DISPLAY ALL GOALS
            else if (userInput == 2){ //RECORD AN EVENT
                int goalID = 0; //Instantiates an iterator to keep track of goal id
                foreach (Goal g in AllGoals)
                {                    
                    Console.Write("Goal #" + goalID++ + " : "); //Displays the goal number
                    g.DisplayShort(); //DIsplays shortened version of full info for ease of listing
                }
                Console.WriteLine("Enter Goal # to mark completed. -1 to cancel.");
                userInput = Convert.ToInt32(Console.ReadLine());  
                if(userInput<0){                    
                    Console.WriteLine("Cancelled");
                } else if (userInput<AllGoals.Count) { //Checks for input in the range of the list
                    if(AllGoals[userInput].GetCompletion() == false)
                    { 
                    int award = AllGoals[userInput].CompleteTask();
                        Console.WriteLine("Awarded " + award + "points!");
                        userPoints = userPoints+ award; //awards the points
                    }
                    else{
                        Console.WriteLine("Error: Goal Already Completed");
                    }
                } else {
                    Console.WriteLine("Error: Invalid input, please enter an integer that matches the Goal Number.");
                }
                
            } //END RECORD AN EVENT
             else if (userInput == 3){ //CREATE A GOAL
                Console.WriteLine("What type of goal do you want to create?");
                Console.WriteLine("1 Simple Goal");
                Console.WriteLine("2 Checklist Goal");
                Console.WriteLine("3 Eternal Goal");
                Console.WriteLine("0 Cancel Creation");
                userInput = Convert.ToInt32(Console.ReadLine());  
                if (userInput == 1)
                { //BEGIN SIMPLE GOAL CREATION
                    Console.WriteLine("Please input the Simple Goal's name");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Please input the description of the goal");
                    string newDesc = Console.ReadLine();
                    Console.WriteLine("As an integer, input the points awarded for completion");
                    int newPoint = Convert.ToInt32(Console.ReadLine());  
                    SimpleGoal newGoal = new(newName, newDesc, false, newPoint);
                    AllGoals.Add(newGoal);
                    Console.WriteLine("Added " + newName + " as new simple goal.");     
                    //END SIMPLE GOAL CREATION               
                } else if (userInput == 2){ //BEGIN CHECKLIST GOAL CREATION
                    Console.WriteLine("Please input the Checklist Goal's name");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Please input the description of the goal");
                    string newDesc = Console.ReadLine();
                    Console.WriteLine("As an integer, input the points each step awards you.");
                    int newStep = Convert.ToInt32(Console.ReadLine());  
                    Console.WriteLine("As an integer, input the points awarded for completion");
                    int newPoint = Convert.ToInt32(Console.ReadLine());  
                    Console.WriteLine("As an integer, input the number of steps it takes to complete this checklist.");
                    int newNumStep = Convert.ToInt32(Console.ReadLine());  
                    CheckGoal newGoal = new(newName, newDesc, false, newPoint, newStep, newNumStep); //New goal will always have 
                    AllGoals.Add(newGoal);
                    Console.WriteLine("Added " + newName + " as new checklist goal.");  
                    //END CHECKLIST GOAL CREATION
                }
                else if (userInput == 3){ //BEGIN ETERNAL GOAL CREATION
                    Console.WriteLine("Please input the Eternal Goal's name");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Please input the description of the goal");
                    string newDesc = Console.ReadLine();
                    Console.WriteLine("As an integer, input the points each step awards you.");
                    int newStep = Convert.ToInt32(Console.ReadLine());  
                    EternalGoal newGoal = new(newName, newDesc, false, newStep); //New goal will always have 
                    AllGoals.Add(newGoal);
                    Console.WriteLine("Added " + newName + " as new eternal goal.");  
                } 
                else if (userInput == 0){
                    Console.WriteLine("Creation Canceled");                    
                }               
            }  //END CREATE GOAL
            else if (userInput == 4){ //SAVE ALL GOALS
                Console.WriteLine("Please enter a filename to save.");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Goal i in AllGoals)
                    {
                        outputFile.WriteLine(string.Join("~!~",i.GetSaveData()));
                    }
                }
                
            } //END SAVE ALL GOALS  
            else if (userInput == 5){ //LOAD ALL GOALS
                Console.WriteLine("Please enter the filename to load.");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("~!~");
                    if(parts[0] == "Simple"){
                        //CREATE SIMPLE FROM STRING ARRAY
                        SimpleGoal newGoal = new(parts); 
                        AllGoals.Add(newGoal);
                        userPoints = userPoints + newGoal.AwardInitialPoints();
                    } else if (parts[0] == "Check"){
                        //CREATE CHECK GOAL FROM STRING ARRAY
                        CheckGoal newGoal = new(parts); 
                        AllGoals.Add(newGoal);
                        userPoints = userPoints + newGoal.AwardInitialPoints();
                    } else if (parts[0] == "Eternal"){
                        //CREATE ETERNAL GOAL FROM STRING ARRAY
                        EternalGoal newGoal = new(parts); 
                        AllGoals.Add(newGoal);
                        userPoints = userPoints + newGoal.AwardInitialPoints();
                    }
                }
                
            } //END LOAD ALL GOALS
            else if (userInput == 0){
                Console.WriteLine("Have a nice day.");
                keepRunningMenu = false;
            } else{
                Console.WriteLine("Unkown input. Please select an option by typing an integer from 0 to 3.");
            }
        }
    }
}