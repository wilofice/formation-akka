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

            Worker worker = new Worker();

            await worker.DoWork().ConfigureAwait(false);

            Console.WriteLine("after running dowork");

            while (!worker.IsCompleted)
            {
                Console.WriteLine("...");
                Thread.Sleep(100);
            }

            Console.WriteLine("Done!");
            Console.ReadKey();
        }


        class Worker
        {

            public bool IsCompleted { get; set; }

            public async Task DoWork()
            {

                Console.WriteLine("In DoWork");

                IsCompleted = false;

                await LongOperation();

                IsCompleted = true;

                Console.WriteLine("End DoWork");

            }

            public async Task LongOperation()
            {
                Console.WriteLine("In LongOperation");

                HttpClient client = new HttpClient();

                var result = await client.GetAsync("https://www.microsoft.com/fr-ma/");

                Console.WriteLine(await result.Content.ReadAsStringAsync());

                Console.WriteLine("End LongOperation");

            }


        }


        
    }
}
