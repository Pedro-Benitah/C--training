using System;
using System.IO;

namespace FileExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\desenvolvimento\Documents\temp\file1.csv";
            string targetPath = @"C:\Users\desenvolvimento\Documents\temp\file2.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
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
