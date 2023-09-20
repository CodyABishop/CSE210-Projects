using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);
        char letter;
        string sign;
        sign = "";
        if (score >= 90){
            letter = 'A';    
        }
        else if (score >= 80){
            letter = 'B';    
        }
        else if (score >= 70){
            letter = 'C';    
        }
        else if (score >= 60){
            letter = 'D';    
        }
        else{
            letter = 'F';    
        }
        if( (score % 10) >= 7  ){
            sign = "+";
        }
        else if ( (score%10) <= 3 ){
            sign = "-";
        }
        
        if (letter == 'A'){
            if (sign == "+"){
                sign = "";
            }
        }
        else if (letter == 'F'){
            sign = "";
        }
            
        if (score >= 70){
            Console.Write("Congratulations, you have passed your course!");
        }
        else{
            Console.Write("Unfortunately, you have not passed this course. Keep trying and you'll get it next time!");
        }
    
        Console.Write("Your final grade was: " + letter + sign +  "!");

    }
}