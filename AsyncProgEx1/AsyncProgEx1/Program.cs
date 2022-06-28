using System;
using System.Threading.Tasks;

namespace AsyncProgEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Method(num);
            Method1();
            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
        

        public static async Task Method(int num)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("First Method" + i);
                    Task.Delay(1000).Wait();
                }
            });
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i <= 25; i++)
                {
                    Console.WriteLine("Second Method" + i);
                    Task.Delay(1000).Wait();
                }
            });
        }
    }
}
