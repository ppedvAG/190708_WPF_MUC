using MVVM_Projekt.Models;
using MVVM_Projekt.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Projekt.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            // Kontrollfreak-Antipattern
            // Korrekt: DependencyInjection
            this.service = new PersonenService();
            GetPersonenCommand = new RelayCommand(GetPersonen);
        }
        private readonly PersonenService service;

        public List<Person> Personen { get; set; }

        public ICommand GetPersonenCommand { get; set; }
        private void GetPersonen(object obj)
        {
            Personen = service.GetPersonen();
        }
    }
}
