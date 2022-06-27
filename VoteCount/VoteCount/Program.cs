using System;
using VoteCount.Entities;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace VoteCount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine(); //@"C:\Users\desenvolvimento\Desktop\ws-treino\VoteCount\VoteCount\bin\Debug\in.csv";

            VotesMailing votesMailing = new VotesMailing();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] vect = sr.ReadLine().Split(';');
                        string name = vect[0];
                        int votes = int.Parse(vect[1]);

                        votesMailing.AddCandidate(new Candidates(name, votes));
                    }
                    Console.WriteLine(votesMailing);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
