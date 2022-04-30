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
    public partial class Registro : ContentPage
    {
        public Registro(String usuario)
        {
            InitializeComponent();
            lblUser.Text = usuario;
           

        }

        public void btnCalcular_Clicked(object sender, EventArgs e)
        {
            
            try
            {
                double monto = Convert.ToDouble(txtMontoInicial.Text);
                if (monto <= 3000)
                {
                    string clientes = txtNombreCliente.Text;
                    double subTotal = (3000 - monto);
                    double interes = (3000 * 5) / 100;
                    double cuota = (subTotal + interes) / 5;
                    txtPagoMensual.Text = cuota.ToString();

                }
                else
                {
                    DisplayAlert("Error", "El valor excede del costo de inscripcion", "Cerrar");
                }
                
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Cerrar");
                throw;
            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {

            string clientes = txtNombreCliente.Text;
            double monto= Convert.ToDouble(txtMontoInicial.Text);
            double subTotal= (3000 - monto);
            double interes= (3000 * 5) / 100;
            double cuota = (subTotal + interes)/5;
            txtPagoMensual.Text = cuota.ToString();

            DisplayAlert("UISRAEL", "Transaccion Exitosa", "Cerrar");
            string user = lblUser.Text;
            string nombreCliente = txtNombreCliente.Text;
            string totalPagar = txtPagoMensual.Text;
            await Navigation.PushAsync(new Resumen(user,nombreCliente,totalPagar));

        }
    }
}