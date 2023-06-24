using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaVeterinario.CapaConexion;
using SistemaVeterinario.CapaLogica.LogicaNegocio;

namespace SistemaVeterinario.CapaLogica.Servicios
{
   public class ServicioExpediente : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }
        public ServicioExpediente()
        {
            respuesta = " ";
            miComando = new SqlCommand();
        }
        public string InsertarExpediente(Expediente elExpediente)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InsertarExpediente");

            miComando.CommandText = "InsertarExpediente";

            miComando.Parameters.Add("Mascota_id", SqlDbType.Int);
            miComando.Parameters["Mascota_id"].Value = elExpediente.Mascota_id;

            miComando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            miComando.Parameters["Veterinario_id"].Value = elExpediente.Veterinario_id;

            miComando.Parameters.Add("Tratamiento_id", SqlDbType.Int);
            miComando.Parameters["Tratamiento_id"].Value = elExpediente.Tratamiento_id;

            miComando.Parameters.Add("Expediente_fecha", SqlDbType.VarChar);
            miComando.Parameters["Expediente_fecha"].Value = elExpediente.Expediente_fecha;

            miComando.Parameters.Add("Expediente_estado", SqlDbType.VarChar);
            miComando.Parameters["Expediente_estado"].Value = elExpediente.Expediente_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion insertar Expediente";
            Console.WriteLine("Fin Gestor insertar Expediente");
            return respuesta;
        }

        public string ModificarExpediente(Expediente elExpediente)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ModificarExpediente");

            miComando.CommandText = "ModificarExpediente";

            miComando.Parameters.Add("Expediente_id", SqlDbType.Int);
            miComando.Parameters["Expediente_id"].Value = elExpediente.Expediente_id;

            miComando.Parameters.Add("Mascota_id", SqlDbType.Int);
            miComando.Parameters["Mascota_id"].Value = elExpediente.Mascota_id;

            miComando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            miComando.Parameters["Veterinario_id"].Value = elExpediente.Veterinario_id;

            miComando.Parameters.Add("Tratamiento_id", SqlDbType.Int);
            miComando.Parameters["Tratamiento_id"].Value = elExpediente.Tratamiento_id;

            miComando.Parameters.Add("Expediente_fecha", SqlDbType.VarChar);
            miComando.Parameters["Expediente_fecha"].Value = elExpediente.Expediente_fecha;

            miComando.Parameters.Add("Expediente_estado", SqlDbType.VarChar);
            miComando.Parameters["Expediente_estado"].Value = elExpediente.Expediente_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Modificar Expediente";
            Console.WriteLine("Fin Gestor Modificar Expediente");
            return respuesta;
        }

        public DataSet ConsultarExpediente(int Expediente_id)
        {
            miComando.CommandText = "ConsultarExpediente";
            miComando.Parameters.AddWithValue("@Expediente_id", SqlDbType.Int);
      
            miComando.Parameters["@Expediente_id"].Value = Expediente_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarExpedientes()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Expedientes");

            miComando.CommandText = "ListarExpedientes";

            DataSet elExpedientes = new DataSet();
            this.abrirConexion();

            elExpedientes = this.seleccionarInformacion(miComando);
            DataTable miTabla = elExpedientes.Tables[0];

            return miTabla;
        }
        public DataTable ListarExpedientesInactivos()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Expedientes Inactivos");

            miComando.CommandText = "ListarExpedientesInactivos";

            DataSet elExpedientes = new DataSet();
            this.abrirConexion();

            elExpedientes = this.seleccionarInformacion(miComando);
            DataTable miTabla = elExpedientes.Tables[0];

            return miTabla;
        }

        public string EliminarExpediente(int Expediente_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Expediente");

            miComando.CommandText = "EliminarExpediente";

            miComando.Parameters.Add("Expediente_id", SqlDbType.Int);
            miComando.Parameters["Expediente_id"].Value = Expediente_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Expediente";

            Console.WriteLine("Fin Gestor eliminar Expediente");
            return respuesta;

        }
        public string InactivarExpediente(int Expediente_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Expediente");

            miComando.CommandText = "InactivarExpediente";

            miComando.Parameters.Add("Expediente_id", SqlDbType.Int);
            miComando.Parameters["Expediente_id"].Value = Expediente_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Expediente";

            Console.WriteLine("Fin Gestor Inactivar Expediente");
            return respuesta;

        }
        public string ActivarExpediente(int Expediente_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor activar Expediente");

            miComando.CommandText = "ActivarExpediente";

            miComando.Parameters.Add("Expediente_id", SqlDbType.Int);
            miComando.Parameters["Expediente_id"].Value = Expediente_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Expediente";

            Console.WriteLine("Fin Gestor activar Expediente");
            return respuesta;

        }









    }
}
