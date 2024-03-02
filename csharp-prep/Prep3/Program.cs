using System;

class Program {
    static void Main(string[] args) {

        string response = "yes";
        do {
            Random randomGenerator = new Random();
            int magic_n = randomGenerator.Next(1, 100);
            int guess_n = -1;
            int count = 0;

            Console.WriteLine("A magic number was generated, could you guess which it is? ");

            while(guess_n != magic_n) {
                count = count + 1;

                Console.Write("What is your guess? ");
                string user_n = Console.ReadLine();
                guess_n = int.Parse(user_n);

                if(guess_n > magic_n) {
                    Console.WriteLine("Lower");
                } else if(guess_n < magic_n) {
                    Console.WriteLine("Higher");
                } else {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You made it in {count} tries");
                    Console.WriteLine("Do you want play again? ");
                    response = Console.ReadLine();
                }
            }
        } while (response == "yes");
    }
}