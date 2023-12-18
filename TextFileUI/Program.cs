using Microsoft.Extensions.Configuration;

namespace TextFileUI
{
    class Program
    {
        private static IConfiguration _config;

        static void Msin(string[] args)
        {


            Console.ReadLine();
        }
        private static void InitializeConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            _config = builder.Build();

        }

    }
}