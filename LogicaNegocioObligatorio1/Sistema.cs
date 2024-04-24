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
        
        public Sistema()
        {
            PrecargarPeones();
            PrecargarTareas();
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
            Empleado empleadoBuscado = BuscarEmpleado(email);

            // Verificar si el empleado existe y es un peón
            if (empleadoBuscado != null && empleadoBuscado is Peon peon)
            {
                // Asignar la tarea al peón
                Peon tipoPeon = (Peon)empleadoBuscado;
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

        private void PrecargarPeones()
        {
            AltaPeon(new Peon("juan.perez@ejemplo.com", "clave123", "Juan Pérez", new DateTime(2018, 5, 12), true,
                "Reparar cercado", new DateTime(2024, 6, 1), false, new DateTime(2024, 6, 15), "Utilizar postes de madera tratada"));

            AltaPeon(new Peon("maria.gomez@ejemplo.com", "password456", "María Gómez", new DateTime(2020, 11, 3), false,
                "Cosechar manzanas", new DateTime(2024, 9, 20), false, new DateTime(2024, 9, 30), "Recolectar solo las maduras"));

            AltaPeon(new Peon("pedro.rodriguez@ejemplo.com", "password789", "Pedro Rodríguez", new DateTime(2017, 2, 28), true,
                "Limpiar establos", new DateTime(2024, 5, 10), false, new DateTime(2024, 5, 15), "Retirar todo el estiércol"));

            AltaPeon(new Peon("laura.sanchez@ejemplo.com", "clave456", "Laura Sánchez", new DateTime(2019, 9, 1), false,
                "Regar invernadero", new DateTime(2024, 7, 15), false, new DateTime(2024, 7, 20), "Revisar sistema de riego"));

            AltaPeon(new Peon("carlos.martinez@ejemplo.com", "password321", "Carlos Martínez", new DateTime(2022, 3, 10), true,
                "Podar árboles frutales", new DateTime(2024, 6, 1), false, new DateTime(2024, 6, 15), "Utilizar herramientas adecuadas"));

            AltaPeon(new Peon("ana.gonzalez@ejemplo.com", "clave789", "Ana González", new DateTime(2016, 11, 20), false,
                "Alimentar ganado", new DateTime(2024, 4, 1), false, new DateTime(2024, 4, 10), "Seguir la dieta establecida"));

            AltaPeon(new Peon("jose.ramirez@ejemplo.com", "password123", "José Ramírez", new DateTime(2021, 7, 15), true,
                "Cosechar tomates", new DateTime(2024, 8, 1), false, new DateTime(2024, 8, 10), "Separar los maduros"));

            AltaPeon(new Peon("sofia.hernandez@ejemplo.com", "clave456", "Sofía Hernández", new DateTime(2018, 2, 1), false,
                "Limpiar granero", new DateTime(2024, 5, 20), false, new DateTime(2024, 5, 30), "Retirar todo el heno seco"));

            AltaPeon(new Peon("luis.torres@ejemplo.com", "password789", "Luis Torres", new DateTime(2020, 6, 15), true,
                "Reparar tractores", new DateTime(2024, 7, 1), false, new DateTime(2024, 7, 15), "Realizar mantenimiento completo"));

            AltaPeon(new Peon("claudia.diaz@ejemplo.com", "clave321", "Claudia Díaz", new DateTime(2019, 4, 1), false,
                "Desmalezar huerto", new DateTime(2024, 6, 10), false, new DateTime(2024, 6, 20), "Eliminar todas las malezas"));
        }

        private void PrecargarTareas()
        {
            for (int i = 0; i <= 15; i++)
            {
                
            }
        }
        public void PrecargarTareas(Empleado empleado)
        {
          
            if (BuscarEmpleado(empleado.Email) == null)
            {
                _especialidades.Add(esp);
            }
            else
            {
                throw new Exception("Ya existe una especialidad con el mismo id");
            }
    }

}
