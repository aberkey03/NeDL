using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string writeText = "This was written to a FILE!";  // Create a text string
      File.WriteAllText("filetest1.txt", writeText);  // Create a file and write the contents of writeText to it

      string readText = File.ReadAllText("filetest1.txt"); // Read the contents of the file
      Console.WriteLine(readText); // Output the content
    }
  }
}