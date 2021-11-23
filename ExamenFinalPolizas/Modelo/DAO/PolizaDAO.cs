using Conexion;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPolizas.Modelo
{
    public class PolizaDAO
    {
        public ConexionODBC ODBC = new ConexionODBC();
        public GeneralDAO general = new GeneralDAO();

        public List<PolizaDetalleDTO> obtenerTiposDeCuenta()
        {
            return general.ObtenerTodo<PolizaDetalleDTO>("select * from polizadetalle;");
        }

        public PolizaDetalleDTO agregarDetalleDePoliza(PolizaDetalleDTO modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO POLIZADETALLE(polizaDetalleId, polizaId, cuentaId, operacionTipoId, fecha, saldo, concepto)" +
                " VALUES  (NULL, ?polizaId?, ?cuentaId?, ?operacionTipoId?, ?fecha?, ?saldo?, ?concepto?);";
                var ValorDeVariables = new PolizaDetalleDTO
                {
                    polizaId = modelo.polizaId,
                    concepto = modelo.concepto,
                    cuentaId = modelo.cuentaId,
                    fecha = modelo.fecha,
                    operationTipoId = modelo.operationTipoId,
                    polizaDetalleId = modelo.polizaDetalleId,
                    saldo = modelo.saldo
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}
