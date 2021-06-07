using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class ClsProduct : ClsPdfCreation
    {
        public int PrdId { get; set; }
        public string ProdName { get; set; }
        public string ProdBrand { get; set; }
    }
}
