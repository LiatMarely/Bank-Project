using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    [Serializable]
    public abstract class Client : Person
    {
        public double _balance { get; set; }
        public string _creditCard { get; set; }
        public List<int> loans { get; set; }
        public int MaxLoans { get; set; }

        public static string GetCreditCardNumber()
        {
            Random rnd = new Random();
            int c = 0; // Start at 1 to ensure the first digit is separated by a space
            string number = "4580 ";
            for (int i = 0; i < 12; i++) // Use 15 instead of 16 to account for the initial four digits
            {
                if (c % 4 == 0 && i != 14) // Only add a space if it's not the final digit
                {
                    number += " ";
                }
                number += rnd.Next(0, 10).ToString();
                c++;
            }
            return number;
        }
        //public override string WhoAmI();

        public Client(string name, int id, string password, double balance) : base(name, id, password)
        {
            this._balance = balance;
            this._creditCard = GetCreditCardNumber();
        }

        public void DeleteLoan(int loan)
        {
            this.loans.Remove(loan);
        }

        public void AddLoan(int loan)
        {
            this.loans.Add(loan);
        }

    }
}

