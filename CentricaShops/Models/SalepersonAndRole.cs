using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentricaShops.Models
{
    public class  SalepersonAndRole
    {
        public string SalePerson { get; set; }
        public bool IsPrimary { get; set; }
        public SalepersonAndRole(string salePerson, bool isPrimary)
        {
            SalePerson = salePerson;
            IsPrimary = isPrimary;
        }
    }
}
