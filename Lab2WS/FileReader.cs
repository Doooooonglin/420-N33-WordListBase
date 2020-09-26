using System;
using System.IO;

namespace Lab2WS
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            // Implement this using info from the slides.
            string[] scrambledWords = File.ReadAllLines(filename);
        
            return scrambledWords;
            
        }
    }
}
