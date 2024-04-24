using System.Globalization;
using LogicaNegocioObligatorio1;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.Marshalling;

namespace InterfazUsuarioObligatorio1
{
    internal class Program
    {
        private static Sistema miSistema = new Sistema();

        static void Main(string[] args)
        {
            int opcion = -1;
            while (opcion != 0)
            {
                Console.WriteLine("Ingrese la opcion deseada");
                MostrarMenu();
                int.TryParse(Console.ReadLine(), out opcion);
                EvaluarOpcionSeleccionada(opcion);
            }

        }

        static void MostrarMenu()
        {
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Listado de todos los animales.");
            Console.WriteLine("2 - Mostrar potreros");
            Console.WriteLine("3 - Modificar precio de la lana");
            Console.WriteLine("4 - Alta bovino.");
        }

        static void EvaluarOpcionSeleccionada(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    MostrarAnimales();
                    break;
                case 2:
                    MostrarPotreros();
                    break;
                case 3:
                    PrecioKgLana();
                    break;
                case 4:
                    AltaBovino();
                    break;

            }
        }

        static void MostrarAnimales()
        {
            foreach (Animal animal in miSistema.Animales)
            {
                Console.WriteLine(animal);
            }
        }

        static void MostrarPotreros()
        {
            try
            {
                Console.WriteLine("Ingrese cantidad de hectareas");
                double.TryParse(Console.ReadLine(), out double hectareas);
                Console.WriteLine("Ingrese capacidad maxima");
                double.TryParse(Console.ReadLine(), out double capacidad);
                List<Potrero> listaDePotreros = miSistema.BuscarPotreros(hectareas, capacidad);
                if (listaDePotreros.Count() == 0)
                {
                  Console.WriteLine("No hay potreros para mostrar en la lista");
                }
                else
                {
                    Console.WriteLine(listaDePotreros);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static void AltaBovino()
        {
            try
            {
                // ingreso de datos por parte del usuario

                Console.WriteLine("Ingrese el ID de la caravana");
                string idCaravana = Console.ReadLine();
                Console.WriteLine("Ingrese el sexo: M o H");
                string sexo = Console.ReadLine();
                Console.WriteLine("Ingrese la raza");
                string raza = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de nacimiento, formato yyyy-mm-dd");
                DateTime.TryParse(Console.ReadLine(), out DateTime fechaDeNacimiento);
                Console.WriteLine("Ingrese el costo de adquisición");
                double.TryParse(Console.ReadLine(), out double costoDeAdquisicion);
                Console.WriteLine("Ingrese el costo de alimentación");
                double.TryParse(Console.ReadLine(), out double costoDeAlimentacion);
                Console.WriteLine("Ingrese el peso actual");
                double.TryParse(Console.ReadLine(), out double pesoActual);
                Console.WriteLine("¿Es un híbrido? Ingrese Sí o No");
                bool hibrido = false;
                if (Console.ReadLine().ToLower() == "si" || Console.ReadLine().ToLower() == "sí")
                {
                    hibrido = true;
                }

                Console.WriteLine("Ingrese el tipo de alimentación");
                for (int i = 0; i < Enum.GetNames(typeof(TipoAlimentacion)).Length; i++)
                {
                    Console.WriteLine(Enum.GetNames(typeof(TipoAlimentacion))[i]);
                }

                string tipoAlimentacion = Console.ReadLine();
                TipoAlimentacion tipoAlimentacionEnum =
                    (TipoAlimentacion)Enum.Parse(typeof(TipoAlimentacion),
                        tipoAlimentacion); // ace estamos casteando la variable tipoAlimentacion para que en vez de ser un string sea del tipo TipoAlimentacion

                // validacion de campos

                if (!string.IsNullOrEmpty(idCaravana) && !string.IsNullOrEmpty(sexo) && !string.IsNullOrEmpty(raza) &&
                    fechaDeNacimiento > DateTime.MinValue && costoDeAdquisicion > 0 && costoDeAlimentacion > 0 &&
                    pesoActual > 0)
                {
                    Animal
                        animalBuscado =
                            miSistema.BuscarAnimal(
                                idCaravana); // deberia ser de tipo animal o bovino? si coloco bovino da error, pues en sistema estaria buscando un bovino e igualandolo a uno en la lista de animales, esto no es posible.
                    if (animalBuscado != null)
                    {
                        Console.WriteLine("Ya existe un animal con el mismo código de identificación.");
                    }
                    else
                    {
                        Bovino nuevoBovino = new Bovino(idCaravana, sexo, raza, fechaDeNacimiento, costoDeAdquisicion,
                            costoDeAlimentacion, pesoActual, hibrido, tipoAlimentacionEnum);
                        miSistema.AltaBovino(nuevoBovino);
                        Console.WriteLine("Alta exitosa");
                    }
                }
                else
                {
                    Console.WriteLine("Los datos no son correctos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void PrecioKgLana()
        {
            Console.WriteLine("Ingrese nuevo precio de lana");
            double.TryParse(Console.ReadLine(), out double nuevoPrecio);
            if (nuevoPrecio != 0)
            {
              Console.WriteLine(miSistema.EstablecerPrecioLana(nuevoPrecio));  
            }
        }
        
        
    }
}
