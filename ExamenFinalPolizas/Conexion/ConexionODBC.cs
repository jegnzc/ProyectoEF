using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPolizas.Conexion
{
    public class ConexionODBC
    {
        private string dsn = "Dsn=conexionHSC";

        /// <summary>
        /// Inicia la conexión hacia ODBC con el DSN especificado.
        /// </summary>
        /// <returns></returns>
        public OdbcConnection abrirConexion()
        {
            OdbcConnection conexion = new OdbcConnection(dsn);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (OdbcException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Cierra la conexión hacia ODBC con el DSN especificado.
        /// </summary>
        /// <param name="conexion"></param>
        public void cerrarConexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
