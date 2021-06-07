using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    public class CustomerDetails
    {
       public long AccountNumber { get; set; }
        public string CustomerName { get; set; }

        private int ATMPin = 1230;

        public bool GetCash()
        {
            if(AccountNumber == 32165494)
            {
                if(ATMPin == 1230)
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
