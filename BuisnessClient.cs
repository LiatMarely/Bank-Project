using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    [Serializable]
    public class BuisnessClient : Client
    {
        public override ePersonsType WhoAmI()
        {
            return ePersonsType.BuisnessClient;
        }

        public BuisnessClient(string name, int id, string password, double balance) : base(name, id, password, balance)
        {
            this.MaxLoans = 5;
            this.loans = new List<int>();
            this._creditCard = GetCreditCardNumber();

        }

        public override String RandomFact()
        {
            List<String> facts = facts = new List<string>();
            facts.Add("Business clients are typically larger than regular clients.");
            facts.Add("Business clients usually have more complex financial needs than regular clients.");
            facts.Add("Business clients often require more specialized services than regular clients.");
            facts.Add("Business clients may have more than one account with the bank.");
            facts.Add("Business clients may have more than one person authorized to access their accounts.");
            Random rand = new Random();
            int index = rand.Next(facts.Count());
            String fact = facts[index];
            return fact;
        }
    }
}


