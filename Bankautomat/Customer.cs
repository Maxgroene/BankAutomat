using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomat
{
    public class Customer
    {
        string firstName, lastName, iban;
        int money;

        public Customer(string firstName, string lastName, string iban, int money)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.iban = iban;
            this.money = money;
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        public string Iban
        {
            get
            {
                return iban;
            }
        }
        public int Money
        {
            get
            {
                return money;
            }
        }
        public int TakeOffMoney
        {
            set
            {
                money = money - value;
            }
        }
    }
}
