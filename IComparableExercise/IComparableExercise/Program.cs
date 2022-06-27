using System;
using System.Collections.Generic;
using System.IO;
using IComparableExercise.Entities;

namespace IComparableExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\desenvolvimento\Desktop\ws-treino\IComparableExercise\IComparableExercise\bin\Debug\in.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
