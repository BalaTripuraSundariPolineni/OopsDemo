using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class ClsCustomer : ClsProduct
    {
        public int custId { get; set; }
        public string custName { get; set; }
        public string DelivaryAddress { get; set; }

    }
}
