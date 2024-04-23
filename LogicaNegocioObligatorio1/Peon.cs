using LogicaNegocioObligatorio1.Interfaces;
using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 using static System.Runtime.InteropServices.JavaScript.JSType;

 namespace LogicaNegocioObligatorio1
 {
     public class Peon : Empleado, IValidable
     {
         private bool _residente;
         private List<Tarea> _tareasAsignadas;
         private Tarea _tareaAsignada;
         
         public List<Tarea> TareasAsignadas
         {
             get { return _tareasAsignadas; }
         }

         public Peon (string email, string contrasenia, string nombre, DateTime fechaIngreso, bool residente, List<Tarea> tareasAsignadas, string descripcion, DateTime fechaPactada, bool completada, DateTime fechaDeCierre, string comentario) : base(email, contrasenia, nombre, fechaIngreso)
         {
             _residente = residente;
             _tareasAsignadas = new List<Tarea>();
             _tareaAsignada = new Tarea(descripcion, fechaPactada, completada, fechaDeCierre, comentario);
             AltaTarea(_tareaAsignada);
         }

        public void Validar() // que significa este error?
        {
            if (_tareasAsignadas.Count ==0)
            {
                throw new Exception("Debe tener por lo menos una tarea asignada.");
            }
        }
        
        

        public void AltaTarea(Tarea nuevaTarea)
        {
            if (!_tareasAsignadas.Contains(nuevaTarea))
            {
                _tareasAsignadas.Add(nuevaTarea);
            }
        }

     }
 }
