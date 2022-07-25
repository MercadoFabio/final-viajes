using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesFinal.Entidades;
using ViajesFinal.Servicios;
using static ViajesFinal.frmViajes;

namespace ViajesFinal.Acceso_a_Datos
{
    class HelperDao
    {
        private static HelperDao instancia;
        private string cadenaConexion;
        SqlConnection cnn;
        SqlCommand cmd;

        private HelperDao() 
        {
            cadenaConexion = Properties.Resources.strConexion;
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();
        
        }

        public static HelperDao ObtenerInstancia() 
        {
            if (instancia == null) 
            {
                instancia = new HelperDao();
            }
            return instancia;
        
        }

        public DataTable ConsultaSql(string query) 
        {
            DataTable table = new DataTable();
            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                table.Load(cmd.ExecuteReader());

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally 
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            
            }

            return table;
        }

        public DataTable ConsultaSqlParametrosEntrada(string query) 
        {
            DataTable table = new DataTable();
            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                table.Load(cmd.ExecuteReader());

            }
            catch (Exception ex)
            {
                table = null;
            }
            finally 
            {
                if (cnn.State == ConnectionState.Open) 
                {
                    cnn.Close(); 
                }
            
            }
            return table;
        
        }

        public int EjecutarSQLParametrosEntrada(string query) 
        {
            int filasAfectadas = 0;

            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                filasAfectadas = cmd.ExecuteNonQuery();



            }
            catch (Exception)
            {

                filasAfectadas = 0;
            }
            finally 
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return filasAfectadas;

        
        }

        public int EjecutarSQLMaestroDetalle(string query, Viaje oViaje, Accion modo) 
        {
            int filasAfectadas = 0;
            //SqlTransaction trans = null;

            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                //trans = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                if (modo == Accion.Create) 
                {

                    cmd.Parameters.AddWithValue("@codigo", oViaje.pCodigo);
                    cmd.Parameters.AddWithValue("@destino", oViaje.pDestino);
                    cmd.Parameters.AddWithValue("@transporte", oViaje.pTransporte);
                    cmd.Parameters.AddWithValue("@tipo", oViaje.pTipo);
                    cmd.Parameters.AddWithValue("@fecha", oViaje.pFecha);

                    filasAfectadas = cmd.ExecuteNonQuery();
                }

                if (modo == Accion.Update) 
                {
                    
                    
                    cmd.Parameters.AddWithValue("@destino", oViaje.pDestino);
                    cmd.Parameters.AddWithValue("@transporte", oViaje.pTransporte);
                    cmd.Parameters.AddWithValue("@tipo", oViaje.pTipo);
                    cmd.Parameters.AddWithValue("@fecha", oViaje.pFecha);

                    filasAfectadas = cmd.ExecuteNonQuery();
                }

                //trans.Commit();

            }
            catch (Exception ex)
            {
                //trans.Rollback();
                filasAfectadas = 0;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
            }

            return filasAfectadas;


        }



    }
}
