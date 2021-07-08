using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    public class LocalPosicionado : Local
    {
        public double ValorFactura { get; set; }

        public override void Factura()
        {
            Console.WriteLine("Valor de Factura: {0}", ValorFactura);
        }
        public override void Mensaje()
        {
            Console.WriteLine("Factura de Local Posicionado...");
        }
    }
}
