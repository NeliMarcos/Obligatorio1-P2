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
        public void AsignarTarea(string email, Tarea tarea)
        {
            // Buscar el empleado por su email
            Empleado empleado = BuscarEmpleado(email);

            // Verificar si el empleado existe y es un peón
            if (empleado != null && empleado is Peon peon)
            {
                // Asignar la tarea al peón
                Peon tipoPeon = (Peon)empleado;
                tipoPeon.AltaTarea(tarea);
                Console.WriteLine("Tarea" + tarea + " asignada al peón con email" + email);
            }
            else
            {
                Console.WriteLine($"No se encontró un peón con el email "+email);
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

        public List<Potrero> BuscarPotreros(double hectareas , double capacidad)
        {
            List<Potrero> _potrerosBuscados = new List<Potrero>();
            int i = 0;
            while(i< _potreros.Count) 
            {
                if (_potreros[i].Hectareas < hectareas && _potreros[i].Capacidad < capacidad)
                {
                    
                    _potrerosBuscados.Add(_potreros[i]);
                }
                i++;
            }

            return _potrerosBuscados;  
        }

        public double EstablecerPrecioLana(double nuevoPrecio)
        {
            return Animal.EstablecerPrecioLanaOvino(nuevoPrecio);
        }

        
    }

}
