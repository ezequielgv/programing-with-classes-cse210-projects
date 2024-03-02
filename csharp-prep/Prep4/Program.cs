using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {

        List<int> numbers = new List<int>();
        int new_number = -1;
        int sum = 0;
        int largest = 0;
        int smallest = int.MaxValue;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while(new_number != 0){
            Console.Write("Enter number: ");
            string u_number = Console.ReadLine();
            new_number = int.Parse(u_number);
            if(new_number != 0){ numbers.Add(new_number); } // Add the typed number to the list unless it's equal 0
            if(new_number > largest) { largest = new_number; }
            if(new_number < smallest && new_number > 0) { smallest = new_number; }
        }

        int total = numbers.Count; // Count how many numbers was added into the list.
        foreach(int n in numbers){ sum = sum + n; }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(double)sum/total}");
        Console.WriteLine($"The largest is: {largest}");
        Console.WriteLine($"The smallest positive is: {smallest}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort(); // Order the list from smallest to largest 
        foreach (int order_n in numbers){ Console.WriteLine(order_n); }
    }
}