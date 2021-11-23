using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPolizas.Modelo
{
    public class PolizaDetalleDTO
    {
        public int polizaDetalleId { get; set; }
        public int polizaId { get; set; }
        public int cuentaId { get; set; }
        public int operationTipoId { get; set; }
        public DateTime fecha { get; set; }
        public double saldo { get; set; }
        public string concepto { get; set; }

    }
}
