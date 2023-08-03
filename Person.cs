using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
        [Serializable]
        public abstract class Person
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Password { get; set; }


        public abstract ePersonsType WhoAmI();

            public Person(string name, int id,string password)
            {
                this.Name = name;
                this.ID = id;
                this.Password = password;
            }

        public abstract String RandomFact();
    }
    }

