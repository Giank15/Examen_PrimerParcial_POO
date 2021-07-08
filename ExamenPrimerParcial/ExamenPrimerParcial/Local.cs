using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    public abstract class Local
    {
        //Propiedades (Caracteristicas)
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Dueño { get; set; }
        public string Creacion { get; set; }

        public virtual void Mostrar()
        {
            Console.WriteLine("Nombre: {0} \nDirreción: {1} \nNombre de dueño: {2} \nFecha de creación: {3}",
                               Nombre, Direccion, Dueño, Creacion);
        }
        public abstract void Factura();
        public abstract void Mensaje();
    }
}
