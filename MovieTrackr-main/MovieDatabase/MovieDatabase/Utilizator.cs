using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Utilizator
    {
        private int index;
        private string name;

        public Utilizator(int Aindex, string Aname)
        {
            index = Aindex;
            name = Aname;
        }
        public int Index
        {
            get {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string Name
        {
            get
            {
                return name; 
            }
            set
            {
                name = value;
            }
        }
    }
}
