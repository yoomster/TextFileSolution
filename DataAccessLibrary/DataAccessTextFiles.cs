using DataAccessLibrary.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class DataAccessTextFiles
    {
        public List<ContactModel> ReadAllRecords(string TextFile)
        {
            if (File.Exists(TextFile) == false)
            {
                return new List<ContactModel>();
            }

            var lines = File.ReadAllLines(TextFile);
            List<ContactModel> output = new();

            foreach (var line in lines)
            {
                ContactModel contact = new ContactModel();
                var vals = line.Split(',');

                if(vals.Length < 4)
                {
                    throw new Exception($"Invalid row of data: {line}");
                }

                contact.FirstName = vals[0];
                contact.LastName = vals[1];
                contact.EmailAddresses = vals[2].Split(';').ToList();
                contact.PhoneNumbers = vals[3].Split(';').ToList();

                output.Add(contact);
            }

            return output; 
        }

        public void WriteAllRecords(List<ContactModel> contacts, string TextFile)
        {
            List<string> lines = new List<string>();

            foreach(var c in contacts)
            {
                lines.Add($"{c.FirstName},{c.LastName},{String.Join(';', c.EmailAddresses)},{String.Join(';', c.EmailAddresses)}");
            }

            File.WriteAllLines(TextFile, lines);
        }

    }
}
