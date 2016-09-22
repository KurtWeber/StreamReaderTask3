using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Remember to add this line when using StreamReader/StreamWriter

namespace StreamReaderTask3

{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("..\\..\\..\\Shakespeare.txt");
            using (reader)  // Auto-Closing between {}  do not need reader.Close();
            {
                // Count to determine number of lines
                int lineNumber = 0;
                
                // Read first line from the text file
                string line = reader.ReadLine();

                // Read the other lines from the text file
                while (line != null)
                {
                    // Increment by 1 (linenumber = linenumber + 1)
                    lineNumber++;
                    // Write line to console
                    int lineLength = line.Length;
                    if (lineLength != 0)
                    {
                        Console.WriteLine(lineLength);
                        // Read next line
                    }
                    line = reader.ReadLine();
                }
                // Close the resource after you've finished using it
                //reader.Close();
            }
        }
    }
}