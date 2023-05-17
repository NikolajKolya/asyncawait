namespace AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task.WaitAll(Method1(), Method2(), Counter());
            Task.Run(() => Counter());
            Task.WaitAll(Method1(), Method2());
        }

        public static async Task Counter()
        {
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(i);

                await Task.Delay(1000);
            }
        }

        public static async Task Method1()
        {
            Console.WriteLine("Method 1 started");

            await Task.Delay(10000);

            Console.WriteLine("Method 1 completed");
        }

        public static async Task Method2()
        {
            Console.WriteLine("Method 2 started");

            await Task.Delay(10000);

            Console.WriteLine("Method 2 completed");
        }
    }
}