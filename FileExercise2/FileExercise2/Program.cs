using System;
using System.IO;

namespace FileExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\desenvolvimento\Documents\temp\file1.csv";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
