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
    public class CuentaTipoDAO
    {
        public ConexionODBC ODBC = new ConexionODBC();
        public GeneralDAO general = new GeneralDAO();

        public List<CuentaTipoDTO> obtenerTiposDeCuenta()
        {
            return general.ObtenerTodo<CuentaTipoDTO>("select * from cuentatipo;");
        }

        public CuentaTipoDTO agregarTipoDeCuenta(CuentaTipoDTO modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO cuentatipo(nombre)" +
                " VALUES  (?nombre?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

    }
}
