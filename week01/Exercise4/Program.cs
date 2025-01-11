using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        //list
        List<int> numbers;
        numbers = new List<int>();

        string userInput;
        int number;

        //sum
        int sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        do{
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);

            numbers.Add(number);
            sum += number;
        }while(number != 0);

        //print
        Console.WriteLine("The sum is: " + sum);

        //calculate the average
        if (numbers.Count > 0){
            double average = numbers.Average();
            Console.WriteLine("The average is: " + average);
        }

        int largest = numbers.Max();
        Console.WriteLine("The largest is: " + largest);
    }
}