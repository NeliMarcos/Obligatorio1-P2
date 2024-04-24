using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioObligatorio1
{
    public class Ovino : Animal
    {
        private double _pesoEstimadoLana;
        private static double s_precioKgLana = 1;
        private static double s_precioKgOvino;

        public double PrecioKgLana
        {
            get { return s_precioKgLana; }
            set { s_precioKgLana = value; }
        }
        public Ovino (string idCaravana, string sexo, string raza, DateTime fechaDeNacimiento, double costoDeAdquisicion, double costoDeAlimentacion, double pesoActual, bool hibrido, double pesoEstimadoLana) : base(idCaravana, sexo, raza, fechaDeNacimiento, costoDeAdquisicion, costoDeAlimentacion, pesoActual, hibrido)
        {
            _pesoEstimadoLana = pesoEstimadoLana;
            
        }

        public static double EstablecerPrecioLana(double nuevoPrecio)
        {
            if (nuevoPrecio != s_precioKgLana)
            {
                s_precioKgLana = nuevoPrecio;
            }

            return s_precioKgLana;
        }
        
    }
}
