using ejercicio1Bucles.Servicios;

namespace ejercicio1Bucles
{
    /// <summary>
    /// Clase principal del program.cs
    /// 25102023 - ipl
    /// </summary>
    class Program
    {
        /// <summary>
        /// Clase por la que se va amandar el programa
        /// 25102023 - ipl
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            solicicitudNumeroInterfaz sn = new solicitudNumeroImplementacion();
            int numero = sn.numeroSolicitado();

            sumaInterfaz si = new sumaImplementacion();
            si.suma( numero);

        }

    }
}

