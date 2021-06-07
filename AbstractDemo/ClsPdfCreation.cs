using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public abstract class ClsPdfCreation
    {
        public void CreatePdfDoc()
        {

        }
        public void PrintProduct()
        {

        }
        public abstract string GetFilePath();

        public virtual string GetFileDetails()
        {
            string filecontant = "Testing virtual and Abstract";
            return filecontant;
        }
    }
}
