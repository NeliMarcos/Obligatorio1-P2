using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioObligatorio1
{
    public class Vacuna:IEquatable<Vacuna>
    {
        private string _nombre;
        private string _descripcion;
        private string _patogeno;

        public Vacuna (string nombre, string descripcion, string patogeno)
        {
            _nombre = nombre;
            _descripcion = descripcion;
            _patogeno = patogeno;
        }

        public bool Equals(Vacuna ? vacuna)
        {
            return _nombre == vacuna._nombre &&
                   _descripcion == vacuna._descripcion
                   && _patogeno == vacuna._patogeno;
        }
    }
}
