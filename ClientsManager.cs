using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    [Serializable]
    public class ClientsManager : Person
    {
        private int _workerID;

        public ClientsManager(int workerID, string name, int id,string password) : base(name, id,password)
        {
            this._workerID = workerID;
        }

        public override ePersonsType WhoAmI()
        {
            return ePersonsType.ClientsManager;
        }

        public int _WorkerID   // property
        {
            get { return _workerID; }   // get method
            set { _workerID = value; }  // set method
        }

        public override String RandomFact()
        {
            List<string>  facts = new List<string>();
            facts.Add("Bank managers who manage clients are responsible for ensuring that their clients’ needs are met.");
            facts.Add("They work with clients to help them achieve their financial goals.");
            facts.Add("They may also be responsible for managing a team of other bank employees.");
            facts.Add("Bank managers who manage clients must have excellent communication skills and be able to build strong relationships with their clients.");
            facts.Add("They must also have a good understanding of the financial products and services that their bank offers.");
            Random rand = new Random();
            int index = rand.Next(facts.Count());
            String fact = facts[index];
            return fact;
        }

    }
}

