using GalaSoft.MvvmLight;
using MVVMLightDemo.Model;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;

namespace MVVMLightDemo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IPersonenService service)
        {
            this.service = service;
            GetPersonenCommand = new RelayCommand(GetPersonen);
        }

        private void GetPersonen()
        {
            Personen = service.GetPersonen();
        }

        private readonly IPersonenService service;

        private List<Person> personen;
        public List<Person> Personen
        {
            get => personen;
            set => Set(ref personen, value);
        }

        public ICommand GetPersonenCommand { get; set; }
    }
}