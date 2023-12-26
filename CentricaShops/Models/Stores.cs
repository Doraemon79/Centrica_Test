using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CentricaShops.Models
{
    public class Stores
    {
        public string Store { get; }

        public Stores(string store)
        {
            Store = store;
        }
    }
}
