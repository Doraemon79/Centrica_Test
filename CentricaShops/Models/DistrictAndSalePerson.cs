using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentricaShops.Models
{
    public class DistrictAndSalePerson
    {
        public string District {  get; set; }
        public SalepersonAndRole salepersonAndRole { get; set; }
        public DistrictAndSalePerson(string district, string salePersonName, bool isPrimary)
        {
            District = district;
            salepersonAndRole = new SalepersonAndRole(salePersonName, isPrimary);
        }

    }
}
