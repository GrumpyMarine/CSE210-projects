using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.IO;

public class Menu
{
    static Journal journal = new Journal();
    static PromptGenerator promptGenerator = new PromptGenerator();

    public static void Journal()
    {
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Wrong number, please try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry()
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Entry entry = new Entry(date, prompt, response);
        journal.AddEntry(entry);
        Console.WriteLine("The entry has been added.");
    }

    static void SaveJournal()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("The journal has been saved.");
    }

    static void LoadJournal()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("The journal has beenloaded.");
    }
}