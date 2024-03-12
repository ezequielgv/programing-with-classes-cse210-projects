using System;
using System.IO;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        DateTime theCurrentTime = DateTime.Now;
        Random random = new();
        List<string> entriesOfToday = new();
        List<string> questionPromts = new() {
            "What were the highlights of your day?", 
            "What challenges did you face today, and how did you handle them?", 
            "Is there anything specific you're grateful for today?", 
            "What did you learn today, whether about yourself or the world around you?", 
            "How did you spend your free time today, and did you enjoy it?"
        };

        string dateShort = theCurrentTime.ToShortDateString().Replace('/', '-');
        string fileName = @$"C:\Users\ezequ\OneDrive\Escritorio\Estudio-Trabajo\BYU\Programing With Classes\programing-with-classes-cse210-projects\prove\Develop02\Journal.txt";
        int option;
        int count = 0;

        do {
            Console.WriteLine();
            Console.WriteLine("1. Create a new entry");
            Console.WriteLine("2. Display the entries typed today");
            Console.WriteLine("3. Load all your journal");
            Console.WriteLine("4. Save your entries typed");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (option) {
                case 1:
                    int numberRandom = random.Next(0, questionPromts.Count);
                    Console.WriteLine($"{questionPromts[numberRandom]}");
                    string newEntry = Console.ReadLine();
                    entriesOfToday.Add($"{dateShort}: {newEntry}");

                    break;
                case 2:
                    Console.WriteLine("Diary Entries:");
                    if (entriesOfToday.Count == 0) { Console.WriteLine("No entries yet."); 
                    } else { foreach (string entry in entriesOfToday) { Console.WriteLine(entry); } }
                    break;
                case 3:
                    string[] lines = System.IO.File.ReadAllLines(fileName); // Obtain the data of the selected file        
                    foreach (string line in lines) { Console.WriteLine(line); } // Read each line into the file
                    break;
                case 4:
                    if (entriesOfToday.Count == 0) { Console.WriteLine("No entries yet.");
                    } else {
                        foreach (string entry in entriesOfToday) {
                            using (StreamWriter outputFile = new StreamWriter(fileName, true)) { outputFile.WriteLine(entriesOfToday[count]); } // Append text to the file
                            count += 1;
                        }
                        Console.WriteLine("All yout entries was saved.");
                    }
                    break;
            }
        } while (option != 5);
    }
}