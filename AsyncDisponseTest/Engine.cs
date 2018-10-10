using System;
using System.Threading.Tasks;

namespace AsyncDisponseTest
{
    public class Engine
    {
        public Task<string> RunAsync()
        {
            using (var client = new Client())
            {
                return client.LongRunningGetAsync("run with using");
            }
        }

        public Task<string> RunWithFinally()
        {
            Client client = null;
            try
            {
                client = new Client();
                return client.LongRunningGetAsync("run with finally");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                client.Dispose();
                Console.WriteLine("Finally was called");
            }
        }
    }
}