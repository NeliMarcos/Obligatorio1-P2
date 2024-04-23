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
        private double _precioKgLana;
        private static double s_precioKgOvino;
        public Ovino (string idCaravana, string sexo, string raza, DateTime fechaDeNacimiento, double costoDeAdquisicion, double costoDeAlimentacion, double pesoActual, bool hibrido, double pesoEstimadoLana, double precioKgLana) : base(idCaravana, sexo, raza, fechaDeNacimiento, costoDeAdquisicion, costoDeAlimentacion, pesoActual, hibrido)
        {
            _pesoEstimadoLana = pesoEstimadoLana;
            _precioKgLana = precioKgLana;
            
        }
    }
}
