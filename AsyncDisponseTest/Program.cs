using System;
using System.Threading.Tasks;

namespace AsyncDisponseTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var engine = new Engine();
            Console.WriteLine(await engine.RunWithFinally());
            Console.Read();
        }
    }
}