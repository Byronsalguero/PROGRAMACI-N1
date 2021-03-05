using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fecha_de_cumpleaños
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CALCULO,  DATO;
            string DIA,MES, RESULTADO, insercion;
            Console.WriteLine("ANOTE EN OTRO LUGAR  EL DIA QUE NACIO (NUMERO)");
            Console.WriteLine("MULTIPLIQUELO POR 20");
            Console.WriteLine("AL RESULTADO  SUMALE 73");
            Console.WriteLine("MULTIPLICALO POR 5 ");
            Console.WriteLine("SUMALE LA FECHA  DEL MES QUE NACISTE");
            Console.WriteLine("PORFAVOR INGRESA EL RESULTADO DE TU OPERACION");

            DATO = Int32.Parse(textdato.Text); //Aca tomamos el dato de la caja de texto
            
            CALCULO = DATO - 365;
            RESULTADO = Convert.ToString(CALCULO);

            
            


            if (RESULTADO.Length<=3)
            {
                insercion = RESULTADO.Insert(0, "0");

                DIA = insercion.Substring(0, 2);
                MES = insercion.Substring(2, 2);

               

            }
            else
            {
                DIA = RESULTADO.Substring(0, 2);
                MES = RESULTADO.Substring(2, 2);

            }


            label11.Text = DIA;
            label12.Text = MES;

            













        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
