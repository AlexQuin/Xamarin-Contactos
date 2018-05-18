using System;
using System.Collections.Generic;
using Contacts.Models;
using Contacts.pages;
using Contacts.viewmodels;
using Xamarin.Forms;

namespace Contacts
{
    public partial class NuevoContactoPage : ContentPage
	{
        public Action<Contacto> AlAgregarContacto { get; set; }
        
		public NuevoContactoPage()
        {
            InitializeComponent();
   
        }

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
            var contacto = new Contacto();
            contacto.Nombre = Nombre.Text;
            contacto.Correo = Correo.Text;
            contacto.Telefono = Telefono.Text;

            AlAgregarContacto?.Invoke(contacto);
            await Navigation.PopAsync();

            //using (var conn = new SQLite.SQLiteConnection(App.RUTA_BD))
            //{
            //    conn.CreateTable<Contacto>();
            //    conn.Insert(contacto);
            //}
		}
    }
}
