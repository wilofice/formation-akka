using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {




        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting");

            var worker = new Worker();

            worker.DoWork();

            while (!worker.IsComplete)
            {
                Console.WriteLine("....");
                Thread.Sleep(100);
            }

            Console.WriteLine($"DoWork method is completed ?");
            Console.ReadKey();
        }


        public static async Task LongOperation()
        {

            Console.WriteLine("Working!");

            HttpClient client = new HttpClient();

            var result = await client.GetAsync("https://www.microsoft.com/fr-ma/");

            Console.WriteLine(await result.Content.ReadAsStringAsync());

            Console.WriteLine("LongOperation Done!");
        }


        class Worker
        {
            public bool IsComplete { get; set; }

            public async Task DoWork()
            {
                this.IsComplete = false;
                Console.WriteLine("Entering DoWork method");

                await LongOperation();

                Console.WriteLine("Work is completed");
                IsComplete = true;
            }

            public Task LongOperation()
            {
                return Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Entering long operation...Working now!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Long operation Done!");
                });
            }
        }
    }
}
