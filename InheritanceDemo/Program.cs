using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsProduct product = new ClsProduct();
            product.CreatePdfDoc();
            product.Printproduct();

            ClsCustomer customer = new ClsCustomer();
            customer.CreatePdfDoc();
            customer.Printproduct();

        }
    }
}
