using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileOperations
{
    class BasicIOOperations
    {
        //Checks for particular file exists or not
        public static void FileExists(string filepath)
        {
            if (File.Exists(filepath))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File not exists");
            }
        }
        //read all the lines one by one in a file
        public static void ReadAllLines(string filepath)
        {
            //The lines are then stored in a string array variable
            string[] lines;
            lines = File.ReadAllLines(filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
        //read all the lines in a file at once
        public static void ReadAllText(string filePath)
        {
            string lines;
            lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
        //delete an existing file
        public static void DeleteFile(string filePath)
        {
            File.Delete(filePath);
            Console.WriteLine("File is deleted");
        }
        //stream reader is used to read data from a file using streams
        public static void ReadFromStreamReader(string filePath)
        {
            
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            
        }
        //The stream writer is used to write data to a file using streams
        public static void WriteUsingStreamWriter(string filePath)
        {
            
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine("Something Written into the file");
                writer.Close();
            }
        }
    }
}
