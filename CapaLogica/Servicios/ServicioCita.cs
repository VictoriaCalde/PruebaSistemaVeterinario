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
    public class ServicioCita : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }

        public ServicioCita()
        {
            respuesta = " ";
            miComando = new SqlCommand();
        }
        public string InsertarCita(Cita laCita)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InsertarCita");

            miComando.CommandText = "InsertarCita";

            miComando.Parameters.Add("Mascota_id", SqlDbType.Int);
            miComando.Parameters["Mascota_id"].Value = laCita.Mascota_id;

            miComando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            miComando.Parameters["Veterinario_id"].Value = laCita.Veterinario_id;

            miComando.Parameters.Add("Cita_hora", SqlDbType.VarChar);
            miComando.Parameters["Cita_hora"].Value = laCita.Cita_hora;

            miComando.Parameters.Add("Cita_fecha", SqlDbType.VarChar);
            miComando.Parameters["Cita_fecha"].Value = laCita.Cita_fecha;

            miComando.Parameters.Add("Cita_estado", SqlDbType.VarChar);
            miComando.Parameters["Cita_estado"].Value = laCita.Cita_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion insertar cita";
            Console.WriteLine("Fin Gestor insertar cita");
            return respuesta;
        }
        public string ModificarCita(Cita laCita)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ModificarCita");

            miComando.CommandText = "ModificarCita";

            miComando.Parameters.Add("Cita_id", SqlDbType.Int);
            miComando.Parameters["Cita_id"].Value = laCita.Cita_id;

            miComando.Parameters.Add("Mascota_id", SqlDbType.Int);
            miComando.Parameters["Mascota_id"].Value = laCita.Mascota_id;

            miComando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            miComando.Parameters["Veterinario_id"].Value = laCita.Veterinario_id;

            miComando.Parameters.Add("Cita_hora", SqlDbType.VarChar);
            miComando.Parameters["Cita_hora"].Value = laCita.Cita_hora;

            miComando.Parameters.Add("Cita_fecha", SqlDbType.VarChar);
            miComando.Parameters["Cita_fecha"].Value = laCita.Cita_fecha;

            miComando.Parameters.Add("Cita_estado", SqlDbType.VarChar);
            miComando.Parameters["Cita_estado"].Value = laCita.Cita_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion modificar cita";
            Console.WriteLine("Fin Gestor modificar cita");
            return respuesta;
        }

        public DataSet ConsultarCita(int Cita_id)
        {
            miComando.CommandText = "ConsultarCita";
            miComando.Parameters.AddWithValue("@Cita_id", SqlDbType.Int);
            miComando.Parameters["@Cita_id"].Value = Cita_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarCitas() 
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Citas");

            miComando.CommandText = "ListarCitas";

            DataSet laCitas = new DataSet();
            this.abrirConexion();

            laCitas = this.seleccionarInformacion(miComando);
            DataTable miTabla = laCitas.Tables[0];

            return miTabla;
        }
        public DataTable ListarCitasInactivas()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Citas Inactivas");

            miComando.CommandText = "ListarCitasInactivos";

            DataSet laCitas = new DataSet();
            this.abrirConexion();

            laCitas = this.seleccionarInformacion(miComando);
            DataTable miTabla = laCitas.Tables[0];

            return miTabla;
        }

        public string EliminarCita(int Cita_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Cita");

            miComando.CommandText = "EliminarCita";

            miComando.Parameters.Add("Cita_id", SqlDbType.Int);
            miComando.Parameters["Cita_id"].Value = Cita_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Cita";

            Console.WriteLine("Fin Gestor eliminar Cita");
            return respuesta;

        }

        public string InactivarCita(int Cita_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Cita");

            miComando.CommandText = "InactivarCita";

            miComando.Parameters.Add("Cita_id", SqlDbType.Int);
            miComando.Parameters["Cita_id"].Value = Cita_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Cita";

            Console.WriteLine("Fin Gestor Inactivar Cita");
            return respuesta;

        }
        public string ActivarCita(int Cita_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Cita");

            miComando.CommandText = "ActivarCita";

            miComando.Parameters.Add("Cita_id", SqlDbType.Int);
            miComando.Parameters["Cita_id"].Value = Cita_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion activar Cita";

            Console.WriteLine("Fin Gestor activar Cita");
            return respuesta;

        }





















    }
}
