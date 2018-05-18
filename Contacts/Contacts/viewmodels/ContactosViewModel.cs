using System;
namespace Contacts.viewmodels
{
    public class ContactosViewModel : BaseViewModel
    {
        public ContactosViewModel()
        {
            EjecutarListado();
        }

        private ObservableRangeCollection<string> _contactos;
        public ObservableRangeCollection<string> Contactos
        {
            get => _contactos;
            set => SetProperty(ref _contactos, value);
        }

        public void EjecutarListado(){
            Contactos = new ObservableRangeCollection<string>();

            Contactos.Add("Alejandro Q.");
            Contactos.Add("Cesar H.");
            Contactos.Add("Fernando M.");
        }
    }
}
