using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace splash
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btn_ingresar(object sender, EventArgs e)
        {
            if ((txt_user.Text == "Juan") && (txt_pass.Text == "123456"))
            {
                await DisplayAlert("Registro", "Es Correocto el usuario", "Cerrar");
            }
            else 
            {
                await DisplayAlert("Registro", "Es incorrecto el usuaio o contraseña", "Cerrar");
            }
        }
    }
}
