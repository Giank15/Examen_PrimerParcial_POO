using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    public class LocalPromocion : Local
    {
        public double CantidadProductos { get; set; }
        public double ValorFactura { get; set; }
        public double Descuento { get; set; }
        public double TotalDescuento { get; set; }
        public double Total { get; set; }

        public override void Factura()
        {
            if (CantidadProductos > 10)
            {
                Descuento = 10;
                TotalDescuento = (Descuento / 100) * ValorFactura;
                Total = ValorFactura - TotalDescuento;
                Console.WriteLine("Cantidad de productos: {0} \nValor de Factura: {1} \nDescuento: {2} \nTotal a pagar: {3}",
                                    CantidadProductos, ValorFactura, Descuento, Total);
            }
            else
            {
                Descuento = 0;
                Console.WriteLine("Cantidad de productos: {0} \nValor de Factura: {1} \nDescuento: {2} \nTotal a pagar: {3}", 
                                    CantidadProductos, ValorFactura, Descuento, ValorFactura);
            }
        }
        public override void Mensaje()
        {
            Console.WriteLine("Factura de Local de Promocion...");
        }
    }
}
