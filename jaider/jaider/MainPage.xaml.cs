using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace jaider
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private async void Alerta1_Clicked(object sender, EventArgs e)
        {
            bool res = await DisplayAlert("Mensjae", "desea valer verga", "azul", "rojo");

            if (res == true)
            {

            }


        }

        private async void opciones_Clicked(object sender, EventArgs e)
        {
            string res = await DisplayActionSheet("Menu", "cancelar","", "Tienda", "Categorias", "Perfil", "Por defecto");

            switch (res)
            {
                case "Tienda":
                    CambiartoTienda();
                    break;
                case "Categorias":
                    CambiartoCategoria();
                    break;
                case "Perfil":
                    CambiartoPerfil();
                    break;
                case "Por defecto":
                    CambiartoPerfil();
                    break;
                default:
                    break;



            }
        }

        private async void iniciar_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new paginaUsuario());
        }


        private async void CambiartoTienda()
        {
           await Navigation.PushModalAsync(new Tienda());
        }
        private async void CambiartoPerfil()
        {
            await Navigation.PushModalAsync(new paginaUsuario());
        }
        private async void CambiartoCategoria()
        {
            await Navigation.PushModalAsync(new Categorias());
        }
       
    }
}
