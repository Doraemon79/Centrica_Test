using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CentricaShops.Models
{
    public class DistrictsAndSalepersons
    {
        private readonly List<DistrictAndSalePerson> _districtAndSalePeople;
        public DistrictsAndSalepersons() 
        {
            _districtAndSalePeople=new List<DistrictAndSalePerson>();
        }

        //public IEnumerable<string> GetDistricts()
        //{
        //    var districts = _districtAndSalePeople.Select(x => x.District).Distinct() ;
        //    return districts;
        //}

        //private void RemoveSalePersonFromDistrict(string District, SalepersonAndRole salePerson)
        //{
        //    if(salePerson.IsPrimary)
        //    {
        //        throw new SalePersonException();
        //    }
        //}

    }
}
