﻿using System.Globalization;

namespace Listas.Entities
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee()
        {
        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary *= 1 + percentage / 100;
        }
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
