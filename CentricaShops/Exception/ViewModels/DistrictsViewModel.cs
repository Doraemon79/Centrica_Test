using CentricaShops.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CentricaShops.Exception.ViewModels
{
    public class DistrictsViewModel:ViewModelBase
    {
        private readonly Districts _districts;   
        public string District { get; }

        public DistrictsViewModel(Districts districts)
        {

            _districts = districts;
        }
    }
}