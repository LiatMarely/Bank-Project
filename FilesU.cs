using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    class FilesU
    {
       public static void SavePersonsToFile(BindingList<Person> persons)
       {
           BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("persons.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, persons);
                binaryFile.Flush();
            }
        }

        public static BindingList<Person> LoadPersonsFromFile()
        {
            BindingList<Person> persons;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("persons.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    persons = (BindingList<Person>)binaryFormatter.Deserialize(binaryFile);
               }
           }
           catch (Exception ex)
           {
               persons = new BindingList<Person>();
               persons.Add(new ClientsManager(1, "admin", 1, "password"));
           }
            return persons;
        }
    }
}

