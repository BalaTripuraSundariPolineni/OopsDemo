using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class AbsDerivedClass : ClsPdfCreation

    {
        public override string GetFilePath()
        {
            string filepath = "c/user/user.exe";
            return filepath;
        }
        public override string GetFileDetails()
        {
            string filecontant = "This is after virtual override";
            return filecontant;
        }
    }
}
