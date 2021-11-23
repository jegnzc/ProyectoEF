using Dapper;
using ExamenFinalPolizas.Conexion;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPolizas.Modelo
{

    public class GeneralDAO
    {
        public ConexionODBC ODBC = new ConexionODBC();

        public List<T> ObtenerTodo<T>(string query)
        {
            List<T> sqlresultado = new List<T>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = query;
                sqlresultado = conexionODBC.Query<T>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

    }
}