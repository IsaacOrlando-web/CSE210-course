using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        //variables
        int grade = 0;
        string letterGrade = "";
        string sign = "";

        // Enter the grade
        Console.Write("Enter the grade: ");
        string userInput = Console.ReadLine();
        grade = int.Parse(userInput);

        // assigns the letter grade 
        if (grade >= 90){
            letterGrade = "A";
        } else if (grade >= 80){
            letterGrade = "B";
        } else if (grade >= 70){
            letterGrade = "C";
        } else if (grade >= 60){
            letterGrade = "D";
        } else {
            letterGrade = "F";
        }

        // assigns the sign                                  
        int lastDigit = grade % 10;
        
        //there is no A+ grade, only A and A-. Add some additional logic to your program to detect this case and handle it correctly.
        if (lastDigit >= 7 && letterGrade != "A" && letterGrade != "F"){
            sign = "+";
        } else if (lastDigit <= 3 && letterGrade != "F"){
            sign = "-";
        }

        // output the letter grade
        Console.WriteLine($"The letter grade is {letterGrade}{sign}");

        //determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.
        if (grade >= 70){
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else{
            Console.WriteLine("You did not pass the course. Keep trying!");
        }
    }
}