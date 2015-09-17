using UnityEngine;
using System.Text;
using System.IO;

private bool Load(string fileName) {
    // Handle any problems that might arise when reading the text
    try {
        string curString;

        StreamReader theReader = new StreamReader(fileName, Encoding.Default);

        using (theReader) {
            // While there's lines left in the text file, do this:
            do {
                curString = theReader.ReadLine();
                if (curString != null) {
                    while (theReader.Peek() != ' ')
                    {

                    }
                }
            } while (line != null);
            theReader.Close();
            return true; // Done reading, close the reader and return true to broadcast success    
        }
    }
    // If anything broke in the try block, we throw an exception with information
    // on what didn't work
    catch (System.Exception e) {
        System.Console.WriteLine("{0}\n", e.Message);
        return false;
    }
}