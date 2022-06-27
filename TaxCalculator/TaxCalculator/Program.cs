using System;
using System.Collections.Generic;
using System.Globalization;
using TaxCalculator.Entities;

namespace TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPlayer> list = new List<TaxPlayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (ch)
                {
                    case ('c'):
                        Console.Write("Number of employees: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());
                        list.Add(new Company(numberOfEmployees, annualIncome, name));
                        break;
                    case ('i'):
                        Console.Write("Health expenditures: ");
                        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Individual(healthExpenditures, annualIncome, name));
                        break;
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double totalTaxes = 0;
            foreach(TaxPlayer player in list)
            {
                Console.WriteLine(player);
                totalTaxes += player.Tax();
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
