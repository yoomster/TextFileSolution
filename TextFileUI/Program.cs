using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace TextFileUI
{
    class Program
    {
        private static IConfiguration _config;
        private static string textFile;
        private static DataAccessTextFiles _db = new DataAccessTextFiles();


        static void Msin(string[] args)
        {
            InitializeConfiguration();
            textFile = _config.GetValue<string>("TextFile");

            ContactModel user1 = new ContactModel
            {
                FirstName="Naomi",
                LastName="Perenboom",
            };
            user1.EmailAddresses.Add("naomi@live.nl");
            user1.EmailAddresses.Add("perenboom@live.nl");
            user1.PhoneNumbers.Add("0612345678");
            user1.PhoneNumbers.Add("0687654321");

            ContactModel user2 = new ContactModel
            {
                FirstName = "Adam",
                LastName = "Akil",
            };
            user2.EmailAddresses.Add("Adam@live.nl");
            user2.EmailAddresses.Add("perenboom@live.nl");
            user2.PhoneNumbers.Add("0612345678");
            user2.PhoneNumbers.Add("0687654333");

            List<ContactModel> contacts = new List<ContactModel>
            {
                user1,
                user2
            };


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