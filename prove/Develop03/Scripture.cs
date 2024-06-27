using System;
using System.Collections.Generic;

public class Scriptures
{
   private List<string> _wordList = new List<string>
   {
        "For","God","so","loved","the","world,","that","he","gave","his","only","begotten","Son","that","whosoever","believeth","in","him","should","not","perish,","but","have","everlasting","life."
   };

    private void ReplaceWithDash()
    {
        Random random = new Random();
        while (true)
        {       
            int index = random.Next(_wordList.Count);
            string randomWord = _wordList[index];


            foreach (string word in _wordList)
            {
                string newWord = word.Replace(randomWord, "_");
                Console.Write(newWord + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine("Type 'quit' to stop or press Enter to continue. ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;
            

        }    
    } 
    public void RunReplaceWithDash()
    {
        ReplaceWithDash();
    }   
}