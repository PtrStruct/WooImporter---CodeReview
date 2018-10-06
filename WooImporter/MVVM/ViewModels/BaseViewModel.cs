using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooImporter.MVVM.ViewModels;

namespace WooImporter.MVVM
{
    public class BaseViewModel
    {
        public ProductsViewModel ProductsViewModel { get; } = new ProductsViewModel();
    }
}
