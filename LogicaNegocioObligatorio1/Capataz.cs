using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocioObligatorio1.Interfaces;

namespace LogicaNegocioObligatorio1
{
    public class Capataz:Empleado
    {
        private int _personasACargo;

        public Capataz(Empleado empleado, string email,string contrasenia,string nombre, DateTime fechaIngreso, int personasACargo):base(email,contrasenia,nombre,fechaIngreso)
        {
            _personasACargo = personasACargo;
        }
    }
    
}
