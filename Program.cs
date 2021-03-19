using System;
using System.Threading;

namespace programa_2
{
    class Program
    {

        static void Main(string[] args)
            //sirve para declarar  un numero estatico.
        {
            byte cantidad, i;
            //
            int numero;
            //permite numeros enteros 
            string linea;
            //devuelve un tipo de variante  de caracteres que se repiten
            Console.Write("Cuantos Números?");
            //es lo que se le pide al usuario que  ingrese
            linea = Console.ReadLine();
            //se le esta diciendo que lea lo que el usuario ingreso 
            cantidad = byte.Parse(linea);
            //
            Random ran = new Random();

            string letra = " ";
            for (i = 1; i <= cantidad; i++)
                //se incrementa el valor del numero 
            {
                numero = Convert.ToInt32(ran.Next(100));
                //
                if (((numero > 0) & (numero < 256)))
                    // es una condicion 
                {
                    letra = Convert.ToString((char)numero);
                    //se convierte el numero en letra 
                    Console.WriteLine($"Código={numero} y letra={letra}");
                    //se le dice que  al ingresa  un munero me muestre el codigo asi que corresponde   y a la letra que corresponde ese codigo 
                }
            }
        }
    }
}