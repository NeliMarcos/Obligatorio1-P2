using LogicaNegocioObligatorio1.Interfaces;

namespace LogicaNegocioObligatorio1
{
    public class Animal: IValidable
    {
        private string _idCaravana;
        private string _sexo;
        private string _raza;
        private DateTime _fechaDeNacimiento;
        private double _costoDeAdquisicion;
        private double _costoDeAlimentacion;
        private double _pesoActual;
        private bool _hibrido;
        private List<Registro> _registros;
        private bool _esLibre;

        public string Caravana
        {
            get { return _idCaravana; }
        }
        public bool EsLibre
        {
            get { return _esLibre; }
            set { _esLibre = value; }
        }
        
       
        public Animal(string idCaravana, string sexo, string raza, DateTime fechaDeNacimiento,
            double costoDeAdquisicion, double costoDeAlimentacion, double pesoActual, bool hibrido)
        {
            _idCaravana = idCaravana;
            _sexo = sexo;
            _raza = raza;
            _fechaDeNacimiento = fechaDeNacimiento;
            _costoDeAdquisicion = costoDeAdquisicion;
            _costoDeAlimentacion = costoDeAlimentacion;
            _pesoActual = pesoActual;
            _hibrido = hibrido;
            _registros = new List<Registro>();
            _esLibre = true;
        }

        public void Validar()
        { 
            
            if (_idCaravana.Length < 8)
            {
                throw new Exception("El código indentificador debe tener un minimo de 8 dígitos.");
            }

        }

        public void AltaRegistro(Registro nuevoRegistro)
        {
            if (_fechaDeNacimiento < _fechaDeNacimiento.AddMonths(3))
            {
                throw new Exception("No se puede vacunar al animal");
            }
            
            if (!_registros.Contains(nuevoRegistro))
            {
                _registros.Add(nuevoRegistro);
            }  
        }
        public override string ToString()
        {
            return "i. " + _idCaravana + "\n"
                + "ii. " + _raza + "\n"
                + "iii. " + _pesoActual + "\n"
                + "iv. " + _sexo + "\n"
                + "---------------" + "\n"; 
        }
    }
}
