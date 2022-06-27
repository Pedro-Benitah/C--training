using System;
using System.Collections.Generic;
using System.IO;
using PriceManagement.Entities;

namespace PriceManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\desenvolvimento\Desktop\ws-treino\PriceManagement\PriceManagement\bin\Debug\SourceFile.csv"; //string sourcePath = @"..\..\..\SourceFile.csv";
            List<Paths> list = new List<Paths>();

            try
            {
                string sourceFolderPath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(';');
                        string name = line[0];
                        double price = double.Parse(line[1]);
                        int quantity = int.Parse(line[2]);
                        list.Add(new Paths(name, price, quantity));
                        
                    }
                    using (StreamWriter sw = File.CreateText(targetFilePath))
                    {
                        foreach(Paths line in list)
                        {
                            sw.WriteLine(line.Name + ';' + line.TotalPrice());
                        }
                    }
                }
            }catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
