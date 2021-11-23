using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPolizas.Modelo
{
    public class PolizaEncabezadoDTO
    {
        public int polizaId { get; set; }
        public int polizaTipoId { get; set; }
        public int empresaId { get; set; }
        public DateTime fecha { get; set; }

    }
}
