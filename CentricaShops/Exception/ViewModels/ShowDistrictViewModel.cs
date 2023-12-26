using CentricaShops.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CentricaShops.Exception.ViewModels
{
    public class ShowDistrictViewModel: ViewModelBase
    {
        private readonly ObservableCollection<DistrictAndSalePerson> _districts;
        //private readonly ObservableCollection<string> _districts1;
        public IEnumerable<string> Districts => GetDistricts();

        public string Districtname { get; }
        public string Saleperson { get; }

        public ICommand SubmitCommand { get; }
      
        public  ShowDistrictViewModel()
        {
            _districts = new ObservableCollection<DistrictAndSalePerson>();

        
            //Test
            _districts.Add(new DistrictAndSalePerson("District1","Mr1",true));
            _districts.Add(new DistrictAndSalePerson("District2", "Mr2", true));
            _districts.Add(new DistrictAndSalePerson("District3", "Mr3", true));
            _districts.Add(new DistrictAndSalePerson("District2", "Mr4", false));


        }
        

        public IEnumerable<string> GetDistricts()
        {
            var districts = _districts.Select(x=>x.District).Distinct();
            return districts;
        }
    }
}
