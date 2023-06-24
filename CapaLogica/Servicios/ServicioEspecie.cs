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
    public class ServicioEspecie : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }

        public ServicioEspecie()
        {
            respuesta = " ";
            miComando = new SqlCommand();
        }
        public string InsertarEspecie(Especie laEspecie)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InsertarEspecie");

            miComando.CommandText = "InsertarEspecie";

            miComando.Parameters.Add("Especie_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Especie_descripcion"].Value = laEspecie.Especie_descripcion;

            miComando.Parameters.Add("Especie_estado", SqlDbType.VarChar);
            miComando.Parameters["Especie_estado"].Value = laEspecie.Especie_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion insertar Especie";
            Console.WriteLine("Fin Gestor insertar Especie");
            return respuesta;
        }

        public string ModificarEspecie(Especie laEspecie)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ModificarEspecie");

            miComando.CommandText = "ModificarEspecie";

            miComando.Parameters.Add("Especie_id", SqlDbType.Int);
            miComando.Parameters["Especie_id"].Value = laEspecie.Especie_id;


            miComando.Parameters.Add("Especie_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Especie_descripcion"].Value = laEspecie.Especie_descripcion;

            miComando.Parameters.Add("Especie_estado", SqlDbType.VarChar);
            miComando.Parameters["Especie_estado"].Value = laEspecie.Especie_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion modificar Especie";
            Console.WriteLine("Fin Gestor modificar Especie");
            return respuesta;

        }
        public DataSet ConsultarEspecie(int Especie_id)
        {
            miComando.CommandText = "ConsultarEspecie";
            miComando.Parameters.AddWithValue("@Especie_id", SqlDbType.Int);
            miComando.Parameters["@Especie_id"].Value = Especie_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarEspecies()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Especies");

            miComando.CommandText = "ListarEspecies";

            DataSet laEspecies = new DataSet();
            this.abrirConexion();

            laEspecies = this.seleccionarInformacion(miComando);
            DataTable miTabla = laEspecies.Tables[0];

            return miTabla;
        }
        public DataTable ListarEspeciesInactivas()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Especies Inactivas");

            miComando.CommandText = "ListarEspeciesInactivos";

            DataSet laEspecies = new DataSet();
            this.abrirConexion();

            laEspecies = this.seleccionarInformacion(miComando);
            DataTable miTabla = laEspecies.Tables[0];

            return miTabla;
        }
        public string EliminarEspecie(int Especie_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Especie");

            miComando.CommandText = "EliminarEspecie";

            miComando.Parameters.Add("Especie_id", SqlDbType.Int);
            miComando.Parameters["Especie_id"].Value = Especie_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Especie";

            Console.WriteLine("Fin Gestor eliminar Especie");
            return respuesta;

        }

        public string InactivarEspecie(int Especie_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Especie");

            miComando.CommandText = "InactivarEspecie";

            miComando.Parameters.Add("Especie_id", SqlDbType.Int);
            miComando.Parameters["Especie_id"].Value = Especie_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Especie";

            Console.WriteLine("Fin Gestor Inactivar Especie");
            return respuesta;

        }
        public string ActivarEspecie(int Especie_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor activar Especie");

            miComando.CommandText = "ActivarEspecie";

            miComando.Parameters.Add("Especie_id", SqlDbType.Int);
            miComando.Parameters["Especie_id"].Value = Especie_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Especie";

            Console.WriteLine("Fin Gestor activar Especie");
            return respuesta;

        }

    }
}
