using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KevinVera
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bienvenida : ContentPage
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("UISRAEL", "Bienvenido al examen Parcial 1", "Regresar");
            await Navigation.PushAsync(new Login());
        }
    }
}