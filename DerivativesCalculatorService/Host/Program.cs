using DerivativesCalculatorService;
using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Type serviceType = typeof(Calculator);
            using (ServiceHost host = new ServiceHost(serviceType))
            {
                try
                {
                    host.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("The derivatives calculator seervice is available.");
                Console.ReadKey();
            }
        }
    }
}