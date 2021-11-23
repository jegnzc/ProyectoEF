using Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPolizas.Modelo
{
    public class OperacionTipoDAO
    {
        public ConexionODBC ODBC = new ConexionODBC();
        public GeneralDAO general = new GeneralDAO();

        public List<OperacionTipoDTO> obtenerTiposDeOperaciones()
        {
            return general.ObtenerTodo<OperacionTipoDTO>("select * from operaciontipo;");
        }
    }
}
