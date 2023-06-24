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
    public class ServicioVeterinario : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }
        public ServicioVeterinario()
        {
            respuesta = " ";
            miComando = new SqlCommand();
        }
        public string InsertarVeterinario(Veterinario elVeterinario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Veterinario");

            miComando.CommandText = "InsertarVeterinario";

            miComando.Parameters.Add("Veterinario_cedula", SqlDbType.Int);
            miComando.Parameters["Veterinario_cedula"].Value = elVeterinario.Veterinario_cedula;

            miComando.Parameters.Add("Veterinario_nombre", SqlDbType.VarChar);
            miComando.Parameters["Veterinario_nombre"].Value = elVeterinario.Veterinario_nombre;

            miComando.Parameters.Add("Veterinario_telefono", SqlDbType.VarChar);
            miComando.Parameters["Veterinario_telefono"].Value = elVeterinario.Veterinario_telefono;

            miComando.Parameters.Add("Veterinario_direccion", SqlDbType.VarChar);
            miComando.Parameters["Veterinario_direccion"].Value = elVeterinario.Veterinario_direccion;

            miComando.Parameters.Add("Veterinario_estado", SqlDbType.VarChar);
            miComando.Parameters["Veterinario_estado"].Value = elVeterinario.Veterinario_estado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion insertar veterinario";
            Console.WriteLine("Fin Gestor insertar veterinario");
            return respuesta;
        }

        public string ModificarVeterinario(Veterinario elVeterinario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Veterinario");

            miComando.CommandText = "ModificarVeterinario";

            miComando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            miComando.Parameters["Veterinario_id"].Value = elVeterinario.Veterinario_id;

            miComando.Parameters.Add("Veterinario_cedula", SqlDbType.Int);
            miComando.Parameters["Veterinario_cedula"].Value = elVeterinario.Veterinario_cedula;

            miComando.Parameters.Add("Veterinario_nombre", SqlDbType.VarChar);
            miComando.Parameters["Veterinario_nombre"].Value = elVeterinario.Veterinario_nombre;

            miComando.Parameters.Add("Veterinario_telefono", SqlDbType.VarChar);
            miComando.Parameters["Veterinario_telefono"].Value = elVeterinario.Veterinario_telefono;

            miComando.Parameters.Add("Veterinario_direccion", SqlDbType.VarChar);
            miComando.Parameters["Veterinario_direccion"].Value = elVeterinario.Veterinario_direccion;

            miComando.Parameters.Add("Veterinario_estado", SqlDbType.VarChar);
            miComando.Parameters["Veterinario_estado"].Value = elVeterinario.Veterinario_estado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Modificar veterinario";
            Console.WriteLine("Fin Gestor Modificar veterinario");
            return respuesta;
        }

        public DataSet ConsultarVeterinario(int Veterinario_id)
        {
            miComando.CommandText = "ConsultarVeterinario";
            miComando.Parameters.AddWithValue("@Veterinario_id", SqlDbType.Int);
            miComando.Parameters["@Veterinario_id"].Value = Veterinario_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarVeterinarios()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Veterinarios");

            miComando.CommandText = "ListarVeterinarios";

            DataSet elVeterinarios = new DataSet();
            this.abrirConexion();

            elVeterinarios = this.seleccionarInformacion(miComando);
            DataTable miTabla = elVeterinarios.Tables[0];

            return miTabla;
        }
        public string EliminarVeterinario(int Veterinario_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Veterinario");

            miComando.CommandText = "EliminarVeterinario";

            miComando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            miComando.Parameters["Veterinario_id"].Value = Veterinario_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Veterinario";

            Console.WriteLine("Fin Gestor Eliminar Veterinario");
            return respuesta;

        }
        public string InactivarVeterinario(int Veterinario_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Veterinario");

            miComando.CommandText = "InactivarVeterinario";

            miComando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            miComando.Parameters["Veterinario_id"].Value = Veterinario_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Veterinario";

            Console.WriteLine("Fin Gestor Inactivar Veterinario");
            return respuesta;

        }

        public string ActivarVeterinario(int Veterinario_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Activar Veterinario");

            miComando.CommandText = "ActivarVeterinario";

            miComando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            miComando.Parameters["Veterinario_id"].Value = Veterinario_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Activar Veterinario";

            Console.WriteLine("Fin Gestor Activar Veterinario");
            return respuesta;

        }
        public DataTable ListarVeterinariosInactivos()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Veterinarios Inactivos");

            miComando.CommandText = "ListarVeterinariosInactivos";

            DataSet elVeterinarios = new DataSet();
            this.abrirConexion();

            elVeterinarios = this.seleccionarInformacion(miComando);
            DataTable miTabla = elVeterinarios.Tables[0];

            return miTabla;
        }
    }
}
