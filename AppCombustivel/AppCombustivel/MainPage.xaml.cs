using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCombustivel
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Calcular_Preco(object sender, EventArgs e)
        {
            Double precoAlcool = Convert.ToDouble(txt_etanol.Text);
            Double precoGasolina = Convert.ToDouble(txt_gasolina.Text);
            Double preco_max_alcool = 0;

            preco_max_alcool = precoGasolina * 0.7;

           try
           {
                if (precoAlcool > preco_max_alcool)
                {
                    txt_resultado.Text = "Compensa a Gasolina";
                }
                else
                {
                    txt_resultado.Text = "Compensa o Alcool";
                }
           }
            catch(Exception ex)
           {
                await DisplayAlert("Ops", ex.Message, "OK");
           }
            
        }
    }
}
