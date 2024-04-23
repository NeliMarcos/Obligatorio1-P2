namespace LogicaNegocioObligatorio1
{
    public class Sistema
    {
        public List<Empleado> _empleados = new List<Empleado>();
        public List<Vacuna> _vacunas = new List<Vacuna>();
        public List<Potrero> _potreros = new List<Potrero>();
        public List<Animal> _animales = new List<Animal>();
        
        public List<Empleado> Empleados
        {
            get { return _empleados; }
        }

        public List<Animal> Animales
        {
            get { return _animales; }
        }
        
        public void AltaCapataz(Capataz nuevoCapataz)
        {
            
            if (!_empleados.Contains(nuevoCapataz))
            {
                _empleados.Add(nuevoCapataz);
            }
            else
            {
                throw new Exception("Ya existe un capataz con los mismos datos.");
            }
        }
        
        
        public void AltaPeon(Peon nuevoPeon)
        {
            
            if (!_empleados.Contains(nuevoPeon))
            {
                _empleados.Add(nuevoPeon);
            }
            else
            {
                throw new Exception("Ya existe un peon con los mismos datos.");
            }
        }

        // ANIMAL
        //EL ALTA SIRVE PARA LOS DOS TIPOS DE ANIMAL

        public void AltaBovino(Bovino nuevoBovino)
        {
            nuevoBovino.Validar();
            if (!_animales.Contains(nuevoBovino))
            {
                _animales.Add(nuevoBovino);
            }
        }
        
        public void AltaOvino(Ovino nuevoOvino)
        {
            nuevoOvino.Validar();
            if (!_animales.Contains(nuevoOvino))
            {
                _animales.Add(nuevoOvino);
            }
        }

        public Animal BuscarAnimal(string idCaravana)
        {
            Animal animalBuscado = null;
            int i = 0;
            while(i< _animales.Count && animalBuscado == null) 
            {
                if (_animales[i].Caravana == idCaravana)
                {
                    animalBuscado = _animales[i];
                }

                i++;
            }

            return animalBuscado;
        }
        
        public void AltaVacuna(Vacuna nuevaVacuna)
        {
            if (!_vacunas.Contains(nuevaVacuna))
            {
                _vacunas.Add(nuevaVacuna);
            }
        }

        public Empleado BuscarEmpleado(string email)
        {
            Empleado empleadoBuscado = null;
            int i = 0;
            while(i< _empleados.Count && empleadoBuscado == null) 
            {
                if (_empleados[i].Email == email)
                {
                    empleadoBuscado = _empleados[i];
                }
            }

            return empleadoBuscado;
        }    
    }

}
