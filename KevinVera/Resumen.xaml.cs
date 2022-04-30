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
    public partial class Resumen : ContentPage
    {
        public Resumen(String user, String nombreCliente,  String totalPagar)
        {
            InitializeComponent();
            user = txtNombreUsuario.Text;
            nombreCliente = txtNombreCliente.Text;
            totalPagar = txtaPagar.Text;
        }
    }
}