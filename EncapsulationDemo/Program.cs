using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            CustomerDetails customerdetails = new CustomerDetails();
            account.GetDetails();
            customerdetails.GetCash(account.GetDetails());
            Console.ReadLine();
             }
    }

    public class BankAccount
    {
        public CustomerDetails GetDetails()
        {
            CustomerDetails customer = new CustomerDetails();

            Console.WriteLine("Enter the customer account number");
            customer.AccountNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the customer name");
            customer.CustomerName = Console.ReadLine();
            return customer;
           
            
        }
       
    }
}
