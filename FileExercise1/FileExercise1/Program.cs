using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\desenvolvimento\Documents\temp\file1.csv";
            string targetPath = @"C:\Users\desenvolvimento\Documents\temp\file2.csv";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}




