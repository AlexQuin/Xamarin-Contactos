using System;
using System.Collections.Generic;
using System.Linq;
using Contacts.Models;
using Contacts.viewmodels;
using Xamarin.Forms;

namespace Contacts.pages
{
    public partial class ContactosPage : ContentPage
    {
        ObservableRangeCollection<Contacto> contactos;
        NuevoContactoPage nuevoContactoPage;

        public ContactosPage()
        {
            InitializeComponent();

            contactos = new ObservableRangeCollection<Contacto>();

            contactosListView.ItemSelected += ContactosListView_ItemSelected;
        } 

        private void ContactosListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactoSeleccionado = e.SelectedItem as Contacto;

            Navigation.PushAsync(new DetallesPage(contactoSeleccionado));

            //contactosListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            contactosListView.ItemsSource = contactos;

            //using (var conn = new SQLite.SQLiteConnection(App.RUTA_BD))
            //{
            //    conn.CreateTable<Contacto>();
            //    contactos = new ObservableRangeCollection<Contacto>(conn.Table<Contacto>().ToList());

            //    contactosListView.ItemsSource = contactos;
            //}
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            nuevoContactoPage = new NuevoContactoPage();
            nuevoContactoPage.AlAgregarContacto += AlAgregarContacto;
            Navigation.PushAsync(nuevoContactoPage);
        }

        private void AlAgregarContacto(Contacto contacto){

            nuevoContactoPage.AlAgregarContacto -= AlAgregarContacto;
            contactos.Add(contacto);
        }
    }
}
