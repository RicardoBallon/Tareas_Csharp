using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using FORM_POO8.INTERFACES;
namespace FORM_POO8.IMPLEMENTACION
{
    class Boleta : Comprobante
    {
        public string ProcesarVenta(int cantidad, string producto, double precio)
        {
            double vv = cantidad * precio;
            string reporte = "Valor de venta: " + vv;
            return reporte;
        }
    }
}
