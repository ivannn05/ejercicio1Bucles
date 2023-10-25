using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Bucles.Servicios
{
    /// <summary>
    /// asignacion de la implementacion a la interfaz 
    /// 25102023 - ipl
    /// </summary>
    internal class solicitudNumeroImplementacion : solicicitudNumeroInterfaz
    {
        /// <summary>
        /// Lamada al metodo que solicita un numero al usuario
        /// 25102023 - ipl
        /// </summary>
        /// <returns></returns>
        public int numeroSolicitado()
        {
            int numeroSolicitado;

            Console.WriteLine("Introduzca un numero mayor que 0");
            numeroSolicitado = Convert.ToInt32(Console.ReadLine());
            return numeroSolicitado;
        } 

       

    }
}   
