 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace LogicaNegocioObligatorio1
 {
     public class Bovino : Animal
     {
         private TipoAlimentacion _tipoAlimentacion;
         private static double s_precioKgBovino;

         public Bovino(string idCaravana, string sexo, string raza, DateTime fechaDeNacimiento, double costoDeAdquisicion, double costoDeAlimentacion, double pesoActual, bool hibrido, TipoAlimentacion tipoAlimentacion) : base(idCaravana, sexo, raza, fechaDeNacimiento, costoDeAdquisicion, costoDeAlimentacion, pesoActual, hibrido)
         {
             _tipoAlimentacion = tipoAlimentacion;
         }
    }
 }
