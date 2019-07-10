using ppedv.NorthwindAgent.Data.EF;
using ppedv.NorthwindAgent.Domain;
using ppedv.NorthwindAgent.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ppedv.NorthwindAgent.UI.WPF
{
    class MainViewModel : BaseViewModel
    {

        public MainViewModel() //(Core core)
        {
            this.core = new Core(new EFRepository(new EFContext()));
            GetCustomersCommand = new RelayCommand(GetCustomers);
        }

        private void GetCustomers(object obj)
        {
            Customers = core.GetAllCustomersWithName(SearchText);
        }

        private readonly Core core;

        private List<Customer> customers;
        public List<Customer> Customers
        {
            get => customers;
            set => SetProperty(ref customers, value);
        }

        public ICommand GetCustomersCommand { get; set; }
        public string SearchText { get; set; }
    }
}
