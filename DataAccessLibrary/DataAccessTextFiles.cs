using DataAccessLibrary.Models;
using System;
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
