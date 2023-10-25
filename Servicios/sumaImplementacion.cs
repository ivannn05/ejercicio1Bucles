using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Bucles.Servicios
{
    /// <summary>
    /// Clase principal para la suma 
    /// 25102023 - ipl
    /// </summary>
    internal class sumaImplementacion : sumaInterfaz
    {
        /// <summary>
        /// Lamada al metodo suma 
        /// 25102023 - ipl
        /// </summary>
        /// <param name="i"></param>
        public void suma(int i)
        {
            int aux = 0;
            for (int contador = 0; contador <= i; contador++)
            {
                aux = aux + contador;

            }
            Console.WriteLine(aux);

        }


    }

}