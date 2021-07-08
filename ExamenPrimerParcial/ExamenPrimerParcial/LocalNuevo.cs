using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    public class LocalNuevo : Local
    {
        public double ValorFactura { get; set; }
        public double Descuento { get; set; }
        public double TotalDescuento { get; set; }
        public double Total { get; set; }

        public override void Factura()
        {
            TotalDescuento = (Descuento / 100) * ValorFactura;
            Total = ValorFactura - TotalDescuento;
            Console.WriteLine("Valor de Factura: {0} \nDescuento: {1} \nTotal a pagar: {2}", ValorFactura, Descuento, Total);
        }
        public override void Mensaje()
        {
            Console.WriteLine("Factura de Local Nuevo...");
        }
    }
}
