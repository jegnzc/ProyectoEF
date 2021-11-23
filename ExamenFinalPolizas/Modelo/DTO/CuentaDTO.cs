using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPolizas.Modelo
{
    public class CuentaDTO
    {
        public int cuentaId { get; set; }
        public int cuentaTipoId { get; set; }
        public string nombre { get; set; }
        public double cargo { get; set; }
        public double abono { get; set; }
        public double saldoAcumulado { get; set; }
        public int cuentaPadreId { get; set; }
    }
}
