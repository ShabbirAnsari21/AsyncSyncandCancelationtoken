using System;
using System.Threading;
using System.Threading.Tasks;

namespace CanTokenProg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter To Get Your Luckey Number \n\n");

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task.Run(() => PrintMyNumber(cancellationToken), cancellationToken);
            Console.ReadLine();

            cancellationTokenSource.Cancel();

            Console.ReadLine();


        }

        public static void PrintMyNumber(CancellationToken cancellationToken)
        {
            var random = new Random();
            int j = -1;
            Console.Write("\b");

            for(int i = 0; i < 30; i++)
            {
                j = random.Next(1, 50);
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b\b");

                if(cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("Your Lucky Number Is " + j);
                    break;
                }
            }
            if(!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("Your Lucky Number Is" + j);
            }

        }

    }
}
