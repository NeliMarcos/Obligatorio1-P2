using LogicaNegocioObligatorio1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicaNegocioObligatorio1
{
    public class Registro:IValidable

    {
    private DateTime _fechaVacunacion;
    private Vacuna _tipoVacuna;
    private DateTime _vencimiento;

    public Registro(DateTime fechaVacunacion, DateTime vencimiento, string nombre, string descripcion,
        string patogeno) // agrege los parametros de vacuna, porq no se puede crear un registro sin crear la vacuna
    {
        _fechaVacunacion = fechaVacunacion;
        _tipoVacuna = new Vacuna(nombre, descripcion, patogeno);
        _vencimiento = vencimiento;
    }

    public void Validar()
    {
        if (_vencimiento != _fechaVacunacion.AddYears(1))
        {
            throw new Exception("El vencimiento no es valido");
        }
    }
    }


}
