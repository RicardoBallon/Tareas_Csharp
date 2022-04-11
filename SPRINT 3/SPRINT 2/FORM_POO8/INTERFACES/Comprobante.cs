using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORM_POO8.INTERFACES
{
    interface Comprobante
    {
        string ProcesarVenta(int cantidad, string producto, double precio);

    }
}
