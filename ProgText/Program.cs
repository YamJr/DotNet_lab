using System;
using System.IO;

class Program
{
    static void Main()
    {
        // File path
        string filePath = "data.txt";

        // Write data to the file
        WriteDataToFile(filePath);

        // Read data from the file
        ReadDataFromFile(filePath);
    }

    static void WriteDataToFile(string filePath)
    {
        // Open the file for writing using TextWriter
        using (TextWriter writer = new StreamWriter(filePath))
        {
            // Write data to the file
            writer.WriteLine("Hello, World!");
            writer.WriteLine("This is a text file.");
        }

        Console.WriteLine("Data written to file successfully.");
    }

    static void ReadDataFromFile(string filePath)
    {
        // Open the file for reading using TextReader
        using (TextReader reader = new StreamReader(filePath))
        {
            // Read and display the data from the file
            string line;
            Console.WriteLine("Read data from file:");
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        Console.WriteLine("Name:Yam Gurung");
        Console.WriteLine("Roll no:31");
        Console.ReadLine();
    }
}
