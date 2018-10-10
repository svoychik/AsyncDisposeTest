using System;
using System.Threading.Tasks;

namespace AsyncDisponseTest
{
    public class Client : IDisposable
    {
        private static bool isDisposed = false;
        public async Task<string> LongRunningGetAsync(string value)
        {
            Console.WriteLine("Long running get called");
            await Task.Delay(5000);
            if(isDisposed) throw new Exception("Client is disposed");
            Console.WriteLine("Delay finished");
            return value.ToUpperInvariant();
        }

        public void Dispose()
        {
            isDisposed = true;
            Console.WriteLine("Client: Dispose called");
        }
    }
}