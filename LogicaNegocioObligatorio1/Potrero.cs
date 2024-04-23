using LogicaNegocioObligatorio1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioObligatorio1
{
    public class Potrero:IValidable
    {
        private int _id;
        private static int s_ultumoId;
        private string _descripcion;
        private double _cantDeHectareas;
        private int _capacidadMaxima;
        private List<Animal> _animalesPastando; 
        
        public Potrero(string descripcion, double cantDeHectareas, int capacidadMaxima, List<Animal> animalesPastando )
        {
             _id = s_ultumoId++;
            _descripcion = descripcion;
            _cantDeHectareas = cantDeHectareas;
            _capacidadMaxima = capacidadMaxima;
            _animalesPastando = new List<Animal>();

        } 

        public void AsignarAnimal(Animal nuevoAnimal)
        { 
            if (nuevoAnimal.EsLibre)
            {
                _animalesPastando.Add(nuevoAnimal);
                nuevoAnimal.EsLibre = false;
            }
            else
            {
                throw new Exception("El animal ya esta asignado a un potrero");
            }
            
        }
        
        public void Validar()
        {
            if (_animalesPastando.Count() == _capacidadMaxima)
            {
                throw new Exception("No se pueden agregar mas animales al potrero");
            }

            {
                
            }
        }
    }
}
