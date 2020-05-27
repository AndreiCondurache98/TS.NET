using MyPhotosService;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace MyPhotosHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            ServiceHost photoHost = new ServiceHost(typeof(PhotoServiceImpl), new Uri("http://localhost:8001/"));
            ServiceHost locationHost = new ServiceHost(typeof(LocationServiceImpl), new Uri("http://localhost:8002/"));
            ServiceHost personHost = new ServiceHost(typeof(PersonServiceImpl), new Uri("http://localhost:8003/"));

            personHost.Open();
            photoHost.Open();
            locationHost.Open();

            Console.WriteLine("Server in executie. Se asteapta conexiuni...");
            Console.WriteLine("Apasati Enter pentru a opri serverul!");
            Console.ReadKey();

            photoHost.Close();
            personHost.Close();
            locationHost.Close();

        }
    }
}
