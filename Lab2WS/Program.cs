using System;
using System.Collections.Generic;
using System.Net;

namespace Lab2WS
{
    class Program
    {
        private static readonly FileReader fileReader = new FileReader();
        private static readonly WordMatcher wordMatcher = new WordMatcher();

        static void Main(string[] args)
        {
             
            
                try
                {
                READ:
                    Console.WriteLine("Enter the scrambled words manually or as a file: f - file, m = manual");


                    string option = Console.ReadLine() ?? throw new Exception("String is null");

                    switch (option.ToUpper())
                    {
                        case "F":
                            Console.WriteLine("Enter the full path and filename >");
                            ExecuteScrambledWordsInFileScenario();

                            break;
                        case "M":
                            Console.WriteLine("Enter word(s) separated by a comma");
                            ExecuteScrambledWordsManualEntryScenario();
                            break;
                        default:
                            Console.WriteLine("The entered option was not recognized");
                            goto READ;

                    }

                    // Optional for now (when you have no loop)  (Take out when finished)
                    Console.ReadKey();
                try
                {
                FINI:
                    Console.WriteLine("Would you like to continue? YES/NO");


                    string end = Console.ReadLine() ?? throw new Exception("String is null");

                    switch (end.ToUpper())
                    {
                        case "YES":
                            Console.WriteLine("We'll go back");
                            goto READ;

                 
                        case "NO":
                            Console.WriteLine("Thanks for using the word matcher");

                            break;
                        default:
                            Console.WriteLine("PLEASE ANSWER YES OR NO!");
                            goto FINI;
                    }

                    // Optional for now (when you have no loop)  (Take out when finished)
                    Console.ReadKey();


                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry an error has occurred.. " + e.Message);

                }

            }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry an error has occurred.. " + e.Message);

                }
            
           
        }

        

        private static void ExecuteScrambledWordsInFileScenario()
        {
            string fileName = Console.ReadLine();
            string[] scrambledWords = fileReader.Read(fileName);
            DisplayMatchedScrambledWords(scrambledWords);
        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            string inputWord = Console.ReadLine();
            string changeWord = string.Join("," , inputWord);
            string[] scrambledWords = changeWord.Split(',');
            DisplayMatchedScrambledWords(scrambledWords);
            
            // 1 get the user's input - comma separated string containing scrambled words
            // 2 Extract the words into a string (red,blue,green) 
            // 3 Call the DisplayMatchedUnscrambledWords method passing the scrambled words string array
            //finish

        }

        private static void DisplayMatchedScrambledWords(string[] scrambledWords)
        {
            string[] wordList = fileReader.Read(@"wordlist.txt"); // Put in a constants file. CAPITAL LETTERS.  READONLY.

            List<MatchedWord> matchedWords = wordMatcher.Match(scrambledWords, wordList);
            if (matchedWords == null)
            {
                Console.WriteLine("No words were founded");
                


            }
            while(matchedWords != null)
            {
                Console.WriteLine("MATCH FOUND FOR{0}:{1}" ,scrambledWords);
                
            }
            

            // Rule:  Use a formatter to display ... eg:  {0}{1}

            // Rule:  USe an IF to determine if matchedWords is empty or not......
            //            if empty - display no words found message.
            //            if NOT empty - Display the matches.... use "foreach" with the list (matchedWords)
        }

    }
}

