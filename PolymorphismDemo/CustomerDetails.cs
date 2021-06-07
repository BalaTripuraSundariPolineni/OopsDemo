using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class CustomerDetails
    {
      
           //Constructor overload
            public CustomerDetails()
            {

            }
            public CustomerDetails(int number)
            {

            }
            public CustomerDetails(string Name)
            {

            }
            public long AccountNumber { get; set; }
            public string CustomerName { get; set; }

            private int ATMPin = 6541;
            public bool GetCash(long AccountNumber)
            {
                if(AccountNumber == 96325741)
                {
                    if(ATMPin == 4541)
                    {
                    
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            public bool GetCash(string CardNumber)
            {
                if (CardNumber == "123475")
                {
                    if (ATMPin == 6541)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            public bool GetCash(long AccountNumber, string CardNumber)
            {
                if (AccountNumber == 96325741 || CardNumber == "123475")
                {
                    if (ATMPin == 6541)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }

    }
}
