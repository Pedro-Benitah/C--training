using System;
using System.IO;

namespace FileExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\desenvolvimento\Documents\temp\file1.csv";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream) { Console.WriteLine(sr.ReadLine()); }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
