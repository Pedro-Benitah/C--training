using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TESTE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fileName = @"CONTAS.txt";

            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split('\t');
                        Console.WriteLine("INSERT INTO LANCAMENTO_CONTABIL VALUES(" + line[0] + "," + line[1] + ",'" + line[2] + "')");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
