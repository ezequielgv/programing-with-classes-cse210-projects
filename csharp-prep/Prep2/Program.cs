using System;

class Program {
    static void Main(string[] args) {

        Console.Write("What is your grade percentage? ");
        string u_answer = Console.ReadLine();
        int percent = int.Parse(u_answer);

        string letter = ""; 
        if (percent >= 90) {
            if((percent - 90) < 3){
                letter = "A-";
            } else {
                letter = "A";
            }
        } else if (percent >= 80){
            if ((percent - 80) >= 7){
                letter = "B+";
            } else if((percent - 80) < 3){
                letter = "B-";
            } else {
                letter = "B";
            }
        } else if (percent >= 70){
            if ((percent - 70) >= 7){
                letter = "C+";
            } else if((percent - 70) < 3){
                letter = "C-";
            } else {
                letter = "C";
            }
        } else if (percent >= 60){
            if ((percent - 60) >= 7){
                letter = "D+";
            } else if((percent - 60) < 3){
                letter = "D-";
            } else {
                letter = "D";
            }
        } else { letter = "F"; }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70) {
            Console.WriteLine("You passed your class");
        } else {
            Console.WriteLine("We sorry, you couldn't pass the class but you can try the next semester!");
        }
    }
}