using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    [Serializable]
    public class RegularClient :Client
    {
        public override ePersonsType WhoAmI()
        {
            return ePersonsType.RegularClient;
        }

        public RegularClient(string name, int id, string password, double balance) : base(name, id, password,balance)
        {
            this.MaxLoans = 3;
            this.loans=new List<int>();
        }

        public override String RandomFact()
        {
            List<String> facts = facts = new List<string>();
            facts.Add("Regular clients are typically individuals or families.");
            facts.Add("Regular clients usually have simpler financial needs than business clients.");
            facts.Add("Regular clients often require fewer specialized services than business clients.");
            facts.Add("Regular clients usually have only one account with the bank.");
            facts.Add("Regular clients usually have only one person authorized to access their accounts.");
            Random rand = new Random();
            int index = rand.Next(facts.Count());
            String fact = facts[index];
            return fact;
        }

    }
}

