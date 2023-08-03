using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project
{
    public class PersonManager
    {
        public static BindingList<Person> persons;
        static PersonManager()
        {
            persons = FilesU.LoadPersonsFromFile();
        }

        public static void savePersons(object sender, FormClosingEventArgs e)
        {
            FilesU.SavePersonsToFile(persons);
        }

        public static BindingList<Person> GetPersons()
        {
            return persons;
        }

        public static void AddPerson(Person person)
        {
            persons.Add(person);
        }
        public static void RemovePerson(Person person)
        {
            persons.Remove(person);
        }

        public static ePersonsType FindPersonType(int id, string password)
        { 
            foreach(Person person in persons)
            {
                if (person.ID.Equals(id) && person.Password.Equals(password))
                {
                    return person.WhoAmI();
                }
            }
            return ePersonsType.None;
        }

        public static BindingList<T> GetSpecificPersons<T>() where T : Person
        {
            BindingList<T> specificPersons = new BindingList<T>();
            foreach (Person person in persons)
            {
                if (person is T)
                {
                    specificPersons.Add(person as T);
                }
            }
            return specificPersons;
        }

        /// ////////////////////

        public static T GetPerson<T>(int id) where T : Person
        {
            foreach (Person person in persons)
            {
                if (person.ID.Equals(id))
                {
                    return (T)person;
                }
            }
            return null;
        }
    }
}

