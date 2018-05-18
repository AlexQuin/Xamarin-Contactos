using System;
using System.Collections.Generic;
using Contacts.Models;
using Xamarin.Forms;

namespace Contacts.pages
{
    public partial class DetallesPage : ContentPage
    {
        public Contacto Contacto { get; set; }

        public DetallesPage(Contacto contacto)
        {
            InitializeComponent();

            Contacto = contacto;

            Title = Contacto.Nombre;

            nombreLabel.Text = Contacto.Nombre;
            telefonoLabel.Text = Contacto.Telefono;
            correoLabel.Text = Contacto.Correo;
        }
    }
}
