using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    internal class DetalleFactura
    {
        private Factura Factura;
        private Producto producto;
        private float precio { get; set; }
        private float iva { get; set; }
        private float subtotal { get; set; }
        private float total { get; set; }
        private int cantidad { get; set; }


    }
}
