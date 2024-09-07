using System;
using Samples.GradeConverterService;
using System.ServiceModel;

namespace Samples.GradeConverterServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Type serviceImplementation = typeof(GradeConverterImplementation);
            var address = new Uri("http://localhost:5388/");
            ServiceHost host = new ServiceHost(serviceImplementation, address);
            using (host)
            {
                host.Open();
                Console.WriteLine("Grade converter service running. Press [Enter] to quit.");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
