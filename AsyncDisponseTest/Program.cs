using System;
using System.Threading.Tasks;

namespace AsyncDisponseTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var engine = new Engine();
                Console.WriteLine(await engine.RunWithAwaitAsync());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.Read();
        }
    }
}