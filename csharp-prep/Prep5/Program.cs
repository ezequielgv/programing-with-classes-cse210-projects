using System;

class Program {
    static void Main(string[] args) {
        FunctionWelcome();
        string userName = UserName();
        int userNumber = UserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void FunctionWelcome(){ Console.WriteLine("Welcome to the Program!"); }
    static string UserName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int UserNumber() {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int n){
        int square = n * n;
        return square;
    }
    static void DisplayResult(string name, int square){ Console.WriteLine($"{name}, the square of your number is {square}"); }
}