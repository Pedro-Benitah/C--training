using System;
using System.Collections.Generic;
using Listas.Entities;
using System.Globalization;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            try
            {
                int n;
                
                Console.Write("How many employees will be registered? ");
                n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Employee #{i}:");
                    Console.Write("Id: ");
                    int idUser = int.Parse((string)Console.ReadLine());
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Salary: ");
                    double salary = double.Parse((string)Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    list.Add(new Employee(idUser, name, salary));
                }

                Console.Write("Enter the employee id that will have salary increase: ");
                int id = int.Parse(Console.ReadLine());

                Employee emp = list.Find(x => id == x.Id);
                if(emp != null)
                {
                    Console.Write("Enter the percentage: ");
                    emp.IncreaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                }
                else{
                    throw (new Exception("This id does not exist!"));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nUpdated list of employees: ");
                foreach(Employee obj in list)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }
}
