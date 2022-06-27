using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_q2.Entities
{
    internal class AverageSalary
    {
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public AverageSalary(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
