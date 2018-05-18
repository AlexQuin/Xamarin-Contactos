using System;
using System.Threading.Tasks;
using Contacts.pages;
using Xamarin.Forms;

namespace Contacts.viewmodels
{
    public class NuevoContactoViewModel : BaseViewModel
    {
        public NuevoContactoViewModel()
        {
            GuardarCommand = new Command(async () => await EjecutarGuardar());
        }      

		private string _nombre;
        public string Nombre
		{
			get => _nombre;
			set => SetProperty(ref _nombre, value);
		}

		private string _correo;
        public string Correo
        {
			get => _correo;
			set => SetProperty(ref _correo, value);
        }

		private string _telefono;
        public string Telefono
        {
			get => _telefono;
			set => SetProperty(ref _telefono, value);
        }

		private string _nota;
        public string Nota
        {
			get => _nota;
			set => SetProperty(ref _nota, value);
        }

        public Command GuardarCommand { get; }

        public async Task EjecutarGuardar(){
			//Nota = $"nombre: {Nombre} - correo: {Correo} - telefono {Telefono}";


			await Application.Current.MainPage.Navigation.PushAsync(new ContactosPage());
		}
    }
}
