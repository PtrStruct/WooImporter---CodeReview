using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WooImporter.Annotations;
using WooImporter.MVVM.Models;

namespace WooImporter.MVVM.ViewModels
{
    public class ProductsViewModel : ObservableObject
    {

        private ObservableCollection<ProductModel> _products = new ObservableCollection<ProductModel>();

        public ObservableCollection<ProductModel> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        
        public ProductsViewModel()
        {
            _products.Add(new ProductModel {Name = "Item 1", Price = "This should be a double"});
            _products.Add(new ProductModel {Name = "Item 2", Price = "This should be a double"});
        }
    }
}
