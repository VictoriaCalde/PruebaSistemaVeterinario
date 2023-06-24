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
    public class ServicioTratamiento : servicio, IDisposable
    {

        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }

        public ServicioTratamiento()
        {
            respuesta = " ";
            miComando = new SqlCommand();
        }

        public string InsertarTratamiento(Tratamiento elTratamiento)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InsertarTratamiento");

            miComando.CommandText = "InsertarTratamiento";

            miComando.Parameters.Add("Medicamento_id", SqlDbType.Int);
            miComando.Parameters["Medicamento_id"].Value = elTratamiento.Medicamento_id;

            miComando.Parameters.Add("Tratamiento_dosis", SqlDbType.VarChar);
            miComando.Parameters["Tratamiento_dosis"].Value = elTratamiento.Tratamiento_dosis;

            miComando.Parameters.Add("Tratamiento_observaciones", SqlDbType.VarChar);
            miComando.Parameters["Tratamiento_observaciones"].Value = elTratamiento.Tratamiento_observaciones;

            miComando.Parameters.Add("Tratamiento_estado", SqlDbType.VarChar);
            miComando.Parameters["Tratamiento_estado"].Value = elTratamiento.Tratamiento_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion insertar Tratamiento";
            Console.WriteLine("Fin Gestor insertar Tratamiento");
            return respuesta;
        }
        public string ModificarTratamiento(Tratamiento elTratamiento)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ModificarTratamiento");

            miComando.CommandText = "ModificarTratamiento";

            miComando.Parameters.Add("Tratamiento_id", SqlDbType.Int);
            miComando.Parameters["Tratamiento_id"].Value = elTratamiento.Tratamiento_id;

            miComando.Parameters.Add("Medicamento_id", SqlDbType.Int);
            miComando.Parameters["Medicamento_id"].Value = elTratamiento.Medicamento_id;

            miComando.Parameters.Add("Tratamiento_dosis", SqlDbType.VarChar);
            miComando.Parameters["Tratamiento_dosis"].Value = elTratamiento.Tratamiento_dosis;

            miComando.Parameters.Add("Tratamiento_observaciones", SqlDbType.VarChar);
            miComando.Parameters["Tratamiento_observaciones"].Value = elTratamiento.Tratamiento_observaciones;

            miComando.Parameters.Add("Tratamiento_estado", SqlDbType.VarChar);
            miComando.Parameters["Tratamiento_estado"].Value = elTratamiento.Tratamiento_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Modificar Tratamiento";
            Console.WriteLine("Fin Gestor Modificar Tratamiento");
            return respuesta;
        }
        public DataSet ConsultarTratamiento(int Tratamiento_id)
        {
            miComando.CommandText = "ConsultarTratamiento";
            miComando.Parameters.AddWithValue("@Tratamiento_id", SqlDbType.Int);
            miComando.Parameters["@Tratamiento_id"].Value = Tratamiento_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarTratamientos()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Tratamientos");

            miComando.CommandText = "ListarTratamientos";

            DataSet elTratamiento = new DataSet();
            this.abrirConexion();

            elTratamiento = this.seleccionarInformacion(miComando);
            DataTable miTabla = elTratamiento.Tables[0];

            return miTabla;
        }
        public DataTable ListarTratamientosInactivos()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Tratamientos Inactivos");

            miComando.CommandText = "ListarTratamientosInactivos";

            DataSet elTratamiento = new DataSet();
            this.abrirConexion();

            elTratamiento = this.seleccionarInformacion(miComando);
            DataTable miTabla = elTratamiento.Tables[0];

            return miTabla;
        }
        public string EliminarTratamiento(int Tratamiento_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Tratamiento");

            miComando.CommandText = "EliminarTratamiento";

            miComando.Parameters.Add("Tratamiento_id", SqlDbType.Int);
            miComando.Parameters["Tratamiento_id"].Value = Tratamiento_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Tratamiento";

            Console.WriteLine("Fin Gestor eliminar Tratamiento");
            return respuesta;

        }
        public string InactivarTratamiento(int Tratamiento_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Tratamiento");

            miComando.CommandText = "InactivarTratamiento";

            miComando.Parameters.Add("Tratamiento_id", SqlDbType.Int);
            miComando.Parameters["Tratamiento_id"].Value = Tratamiento_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Tratamiento";

            Console.WriteLine("Fin Gestor eliminar Tratamiento");
            return respuesta;

        }
        public string ActivarTratamiento(int Tratamiento_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor activar Tratamiento");

            miComando.CommandText = "ActivarTratamiento";

            miComando.Parameters.Add("Tratamiento_id", SqlDbType.Int);
            miComando.Parameters["Tratamiento_id"].Value = Tratamiento_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Tratamiento";

            Console.WriteLine("Fin Gestor activar Tratamiento");
            return respuesta;

        }

    }
}

