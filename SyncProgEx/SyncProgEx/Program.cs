using System;
using System.Threading.Tasks;

namespace SyncProgEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Method();
            Method1();
            //Console.WriteLine("Hello World!");
        }


        public static void Method()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("First Method" + i);
                Task.Delay(100).Wait();
            }
        }

        public static void Method1()
        {
            for(int i = 0; i< 10;i++)
            {
                Console.WriteLine("Second Method" + i);
                Task.Delay(100).Wait();
            }
        }



    }
}
