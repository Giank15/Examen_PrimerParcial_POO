using System;
using System.Collections.Generic;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FACTURAS");
            //Local Nuevo
            LocalNuevo local1 = new LocalNuevo();
            local1.Nombre = "Tienda DulceMaria";
            local1.Direccion = "Barrio Esperanza";
            local1.Dueño = "Juan Perez";
            local1.Creacion = "12 de Julio";
            local1.ValorFactura = 15.50;
            local1.Descuento = 12;
            //Locales de Promocion
            LocalPromocion local2 = new LocalPromocion();
            local2.Nombre = "Cincuentazo Ramirez";
            local2.Direccion = "Barrio Los Esteros";
            local2.Dueño = "Dereck Fisher";
            local2.Creacion = "21 de Mayo";
            local2.CantidadProductos = 5;
            local2.ValorFactura = 19;

            LocalPromocion local3 = new LocalPromocion();
            local3.Nombre = "Cincuentazo Ramirez";
            local3.Direccion = "Barrio Los Esteros";
            local3.Dueño = "Dereck Fisher";
            local3.Creacion = "21 de Mayo";
            local3.CantidadProductos = 12;
            local3.ValorFactura = 26;
            //Local Posicionado
            LocalPosicionado local4 = new LocalPosicionado();
            local4.Nombre = "Despensas Sol Naciente";
            local4.Direccion = "Barrio El Palmar";
            local4.Dueño = "Gabriela Queirolo";
            local4.Creacion = "8 de Octubre";
            local4.ValorFactura = 21.60;

            List<Local> Lista = new List<Local>();
            Lista.Add(local1);
            Lista.Add(local2);
            Lista.Add(local3);
            Lista.Add(local4);

            foreach (Local locales in Lista)
            {
                locales.Mensaje();
                locales.Mostrar();
                locales.Factura();
                Console.WriteLine();
            }
        }
    }
}
