using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace repasoB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class page1 : ContentPage
    {
        public page1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "uisrael";
            string contrasena = "2023";
            if (txtUsuario.Text == usuario && txtContrasena.Text == contrasena)
            {
                Navigation.PushAsync(new Page2(usuario, contrasena));
            }
            else
            {
                DisplayAlert("Alerta", "usuario o clave incorrecta", "cerrar");
            }
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}