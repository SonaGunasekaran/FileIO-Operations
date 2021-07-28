using System;
using System.Text;
using System.IO;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File IO operations!");
            string filepath = @"C:\Users\Sona G\source\repos\FileOperations\FileOperations\FileTest.txt";
            //string outputFile = @"C:\Users\Sona G\Documents\FileTestIO.txt";
            BasicIOOperations.FileExists(filepath);
            BasicIOOperations.ReadAllText(filepath);
            //BasicIOOperations.DeleteFile(filepath);
            BasicIOOperations.ReadFromStreamReader(filepath);
            BasicIOOperations.WriteUsingStreamWriter(filepath);
            Console.Read();
        }
    }
}
