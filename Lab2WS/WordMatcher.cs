  using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab2WS
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();

            foreach (string scrambledWord in scrambledWords)
            {
                foreach (string word in wordList)
                {
                    if (scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        //matchedWords.Add(BuildMatchedWord(scrambledWord, word));

                        matchedWords.Add(new MatchedWord() { ScrambledWord = scrambledWord, Word = word });

                    }
                    else
                    {
                        char[] strWordChar = word.ToCharArray();
                        Array.Sort(strWordChar);
                        string sorted;
                        foreach (var srd in strWordChar)
                        {
                            sorted = srd.ToString();

                            if (sorted.Equals(word, StringComparison.OrdinalIgnoreCase))
                            {
                                matchedWords.Add(BuildMatchedWord(scrambledWord, word));



                            }
                        }

                        }

                        //convert strings into character arrays i.e. ToCharArray()
                        //sort both character arrays
                        //convert sorted character arrays into strings (toString)
                        // 
                        //compare the two sorted strings. If they match, build the MatchWord
                        //struct and add to matchedWords list.
                    

                }
            }

            return null;
        }

        MatchedWord BuildMatchedWord(string scrambledWord, string word)
        {
            MatchedWord matchedWord = new MatchedWord()
            {
                ScrambledWord = scrambledWord,
                Word = word
            };

            return matchedWord;
        }



    }
}

        MatchedWord BuildMatchedWord(string scrambledWord, string word)
        {
            MatchedWord matchedWord = new MatchedWord()
            {
                ScrambledWord = scrambledWord,
                Word = word
            };

            return matchedWord;
        }



    }
}

