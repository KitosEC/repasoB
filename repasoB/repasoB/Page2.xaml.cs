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
    public partial class Page2 : ContentPage

    {
        string usuario;
        public Page2(string usuario, string contrasena)
        {
            InitializeComponent();
            lblusuario.Text = "usuario conectado" + usuario;
            this.usuario = usuario;
        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {
            //rango del 1 al 100
            try
            {
                double dato = Convert.ToDouble(txtDato.Text);
                if(dato > 100)
                {
                    DisplayAlert("Alerta", "fuera de rango", "cerrar");
                }
            }
            catch (Exception)
            {

            
            }
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(txtDato.Text);
            string estudiante = pkEstudiantes.SelectedItem.ToString();

            Navigation.PushAsync(new Page3(usuario, dato, estudiante));
        }
    }
}