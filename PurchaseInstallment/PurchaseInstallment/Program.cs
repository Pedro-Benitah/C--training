using System;
using PurchaseInstallment.Entities;
using PurchaseInstallment.Services;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseInstallment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract newContract = new Contract(number, date, contractValue);
            ContractService contractService = new ContractService(new PaypalService());

            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            contractService.ProcessContract(newContract, numberOfInstallments);

            Console.WriteLine("Installments:");
            foreach(Installment installment in newContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
