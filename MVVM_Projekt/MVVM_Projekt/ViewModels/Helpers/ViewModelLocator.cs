using MVVM_Projekt.Models;
using MVVM_Projekt.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Projekt.ViewModels.Helpers
{
    public class ViewModelLocator
    {

        private IPersonenService service;
        private IPersonenService Service
        {
            get
            {
                if (service == null)
                    service = new PersonenService();
                return service; // Alternative: liefere jedes mal einen neuen Service zurück
            }
        }

        private MainViewModel main;
        public MainViewModel Main
        {
            get
            {
                if (main == null)
                    main = new MainViewModel(Service);
                return main;
            }
        }
        // Alle 50 ViewModels für die Oberfläche
    }
}
