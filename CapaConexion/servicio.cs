using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaVeterinario.CapaConexion
{
    public class servicio
    {
        private SqlConnection conexion;


        public servicio()
        {

            conexion = new SqlConnection(@"user= LAPTOP-1P50TQ8M\Usuarió;
                                         password=validpassword; 
                                         server=LAPTOP-1P50TQ8M;
                                         Trusted_Connection= yes; 
                                         database=SistemaVeterinario;
                                         connection timeout=30");
        }
        protected void abrirConexion()
        {
            conexion.Open();
        }
        protected void cerrarConexion()
        {
            conexion.Close();
        }
        protected string ejecutaSentencia(string sentencia)
        {
            SqlCommand comando = new SqlCommand(sentencia, conexion);

            try
            {
                this.abrirConexion();
                comando.ExecuteScalar();
            }
            catch (Exception error)
            {
                this.cerrarConexion();
                return error.Message;
            }
            this.cerrarConexion();
            return " ";

        }
        protected string ejecutaSentencia(SqlCommand miComando)
        {
            miComando.Connection = conexion;
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.CommandTimeout = 6000;

            try
            {
                this.abrirConexion();
                miComando.ExecuteScalar();

            }
            catch (Exception error)
            {
                this.cerrarConexion();
                return error.Message;
            }
            this.cerrarConexion();
            return " ";
        }
        protected DataSet seleccionarInformacion(string sentencia)
        {
            DataSet miDataSet = new DataSet();
            SqlCommand miSqlCommand = conexion.CreateCommand();

            miSqlCommand.CommandText = sentencia;
            SqlDataAdapter miSqlDataAdapter = new SqlDataAdapter ();

            miSqlDataAdapter.SelectCommand = miSqlCommand;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }
        protected DataSet seleccionarInformacion(SqlCommand miComando)
        {
            DataSet miDataSet = new DataSet();
            SqlDataAdapter miSqlAdapter = new SqlDataAdapter();

            miComando.CommandTimeout = 2000;
            miComando.Connection = conexion;

            miComando.CommandType = CommandType.StoredProcedure;
            miSqlAdapter.SelectCommand = miComando;
            miSqlAdapter.Fill(miDataSet);

            return miDataSet;
}
       

        }
}