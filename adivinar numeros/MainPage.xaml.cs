using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace adivinar_numeros
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var numero= Double.Parse(NUMERO1.Text);

            var por_dos= Double.Parse(NUMERO2.Text);
            var SUMALE_8 = Double.Parse(SUM8.Text);
            var multi_5 = Double.Parse(multi5.Text);

            var result= (numero * por_dos );
            var resull = result + SUMALE_8;

            var resulll = resull * multi_5;
            RESULTDO.Text = resulll.ToString();

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var resultsin = double.Parse(RESIN.Text);
            var resta = double.Parse(REST.Text);
            var total = resultsin - resta;
            

           RESULTADO.Text = total.ToString();




        }
    }
}
