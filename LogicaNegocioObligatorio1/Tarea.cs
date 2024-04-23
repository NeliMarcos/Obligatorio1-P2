using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioObligatorio1
{
    public class Tarea
    {
        private int _id;
        private static int s_ultimoId;
        private string _descripcion;
        private DateTime _fechaPactada;
        private bool _completada;
        private DateTime _fechaDeCierre;
        private string _comentario;

        public Tarea (string descripcion, DateTime fechaPactada, bool completada, DateTime fechaDeCierre, string comentario)
        {
            _id = s_ultimoId++;
            _descripcion = descripcion;
            _fechaPactada = fechaPactada;
            _completada = completada;
            _fechaDeCierre = fechaDeCierre;
            _comentario = comentario;
        }
        
    }

   
}
