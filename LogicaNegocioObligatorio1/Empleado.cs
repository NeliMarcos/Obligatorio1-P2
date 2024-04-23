using LogicaNegocioObligatorio1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioObligatorio1
{
    public class Empleado:IValidable
    {
        private string _email;
        private string _contrasenia;
        private string _nombre;
        private DateTime _fechaIngreso;

        public string Email
        {
            get
            {
                return _email;
            }
        }
        public Empleado(string email, string contrasenia, string nombre, DateTime fechaIngreso)
        {
            _email = email;
            _contrasenia = contrasenia;
            _nombre = nombre;
            _fechaIngreso = fechaIngreso;
        }
       

        public bool Equals(Empleado? empleado)
        {
            return _email == empleado._email &&
                   _contrasenia == empleado._contrasenia &&
                   _nombre == empleado._nombre &&
                   _fechaIngreso == empleado._fechaIngreso;

        }

        public void Validar()
        {
            if(_contrasenia.Length < 8 )
            {
                throw new Exception("La contraseña debe tener 8 caracteres");
            }
        }
    // public override string ToString()
    // {
    //     return "El email del empleado es " + _email + "\n" +
    //            "La contrasenia es " + _contrasenia + "\n" +
    //            "El nombre es " + _nombre + "\n" +
    //            "La fecha de ingreso es " + _fechaIngreso;
    //
    // }
    }
    
}
