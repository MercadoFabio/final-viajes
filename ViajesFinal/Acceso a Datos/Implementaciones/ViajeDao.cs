using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesFinal.Acceso_a_Datos.Interfaces;
using ViajesFinal.Entidades;
using ViajesFinal.Servicios;
using static ViajesFinal.frmViajes;

namespace ViajesFinal.Acceso_a_Datos.Implementaciones
{
    class ViajeDao : IViajesDao
    {
        public bool BorrarViaje(int nroViaje)
        {
            
            bool resultado = true;
            int filasAfectadas = 0;

            string query = "DELETE From Viajes WHERE codigo = " + nroViaje;

            filasAfectadas = HelperDao.ObtenerInstancia().EjecutarSQLParametrosEntrada(query);

            if (filasAfectadas == 0) resultado = false;

            return resultado;
        }

        public bool EditarViaje(Viaje oViaje)
        {
            bool resultado = true;
            int filasAfectadas = 0;

            int codigo = oViaje.pCodigo;

            string query = "UPDATE Viajes SET destino = @destino, transporte = @transporte, tipo = @tipo, fecha = @fecha WHERE codigo =" + codigo;

            filasAfectadas = HelperDao.ObtenerInstancia().EjecutarSQLMaestroDetalle(query, oViaje, Accion.Update);

            if (filasAfectadas == 0) resultado = false;

            return resultado;
        }

        public bool InsertarNuevoViaje(Viaje oViaje)
        {
            bool resultado = true;
            int filasAfectadas = 0;

            string query = "INSERT INTO Viajes values (@codigo, @destino, @transporte, @tipo, @fecha)";

            filasAfectadas = HelperDao.ObtenerInstancia().EjecutarSQLMaestroDetalle(query, oViaje, Accion.Create);
            

            if (filasAfectadas == 0) resultado = false;
            return resultado;
        }

        public List<Transporte> ObtenerTransporte()
        {
            List<Transporte> lst = new List<Transporte>();
            DataTable table = HelperDao.ObtenerInstancia().ConsultaSql("SELECT idTransporte, nombreTransporte  FROM Transportes");
            foreach (DataRow row in table.Rows) 
            {
                Transporte oTransporte = new Transporte();
                oTransporte.IdTransporte = Convert.ToInt32(row["idTransporte"].ToString());
                oTransporte.NombreTransporte = row["nombreTransporte"].ToString();

                lst.Add(oTransporte);
            }

            return lst;
        }

        public Viaje ObtenerViajeId(int nroIdViaje)
        {
            Viaje oViaje = new Viaje();
            DataTable table = new DataTable();
          

            table = HelperDao.ObtenerInstancia().ConsultaSqlParametrosEntrada("select * from Viajes where codigo = " + nroIdViaje);

            bool primerRegistro = true;

            DataTableReader reader = table.CreateDataReader();

            while (reader.Read()) 
            {
                if (primerRegistro) 
                {
                    oViaje.pCodigo = Convert.ToInt32(reader["codigo"].ToString());
                    oViaje.pDestino = reader["destino"].ToString();
                    oViaje.pTransporte = Convert.ToInt32(reader["transporte"].ToString());
                    oViaje.pTipo = Convert.ToInt32(reader["tipo"].ToString());
                    oViaje.pFecha = Convert.ToDateTime(reader["fecha"].ToString());
                }
                primerRegistro = false;
            
            }

            return oViaje;
        }

        DataTable IViajesDao.ObtenerListaViajes()
        {
            DataTable table = HelperDao.ObtenerInstancia().ConsultaSql("Select V.codigo as codigo, CONVERT(varchar,V.codigo) + ' - ' + V.destino as 'Lista'  FROM Viajes V ORDER BY 1");
            return table;
        }
    }
}
