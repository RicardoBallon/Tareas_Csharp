using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using FORM_POO8.INTERFACES;

namespace FORM_POO8.IMPLEMENTACION
{
    class Factura : Comprobante
    {
        public string ProcesarVenta(int cantidad, string producto, double precio)
        {
            double vv = cantidad * precio;
            double igv = vv * 0.18;
            double pv = vv + igv;
            string reporte ="Valor de Venta: " + vv +
                            "\nIGV: " + igv +
                            "\nPrecio de Venta: " + pv;
            return reporte;
        }
    }
}
