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
    public class ServicioMedicamento : servicio, IDisposable
    {

        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }

        public ServicioMedicamento()
        {
            respuesta = " ";
            miComando = new SqlCommand();
        }
        public string InsertarMedicamento(Medicamento elMedicamento)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InsertarMedicamento");

            miComando.CommandText = "InsertarMedicamento";

            miComando.Parameters.Add("Medicamento_nombre", SqlDbType.VarChar);
            miComando.Parameters["Medicamento_nombre"].Value = elMedicamento.Medicamento_nombre;

            miComando.Parameters.Add("Medicamento_dosis", SqlDbType.VarChar);
            miComando.Parameters["Medicamento_dosis"].Value = elMedicamento.Medicamento_dosis;

            miComando.Parameters.Add("Medicamento_estado", SqlDbType.VarChar);
            miComando.Parameters["Medicamento_estado"].Value = elMedicamento.Medicamento_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion insertar Medicamento";
            Console.WriteLine("Fin Gestor insertar Medicamento");
            return respuesta;
        }
        public string ModificarMedicamento(Medicamento elMedicamento)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ModificarMedicamento");

            miComando.CommandText = "ModificarMedicamento";

            miComando.Parameters.Add("Medicamento_id", SqlDbType.Int);
            miComando.Parameters["Medicamento_id"].Value = elMedicamento.Medicamento_id;

            miComando.Parameters.Add("Medicamento_nombre", SqlDbType.VarChar);
            miComando.Parameters["Medicamento_nombre"].Value = elMedicamento.Medicamento_nombre;

            miComando.Parameters.Add("Medicamento_dosis", SqlDbType.VarChar);
            miComando.Parameters["Medicamento_dosis"].Value = elMedicamento.Medicamento_dosis;

            miComando.Parameters.Add("Medicamento_estado", SqlDbType.VarChar);
            miComando.Parameters["Medicamento_estado"].Value = elMedicamento.Medicamento_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion modificar Medicamento";
            Console.WriteLine("Fin Gestor modificar Medicamento");
            return respuesta;
        }

        public DataSet ConsultarMedicamento(int Medicamento_id)   
        {
            miComando.CommandText = "ConsultarMedicamento";
            miComando.Parameters.AddWithValue("@Medicamento_id", SqlDbType.Int);
            miComando.Parameters["@Medicamento_id"].Value = Medicamento_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarMedicamentos() 
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Medicamentos");

            miComando.CommandText = "ListarMedicamentos";

            DataSet elMedicamento = new DataSet();
            this.abrirConexion();

            elMedicamento = this.seleccionarInformacion(miComando);
            DataTable miTabla = elMedicamento.Tables[0];

            return miTabla;
        }
        public DataTable ListarMedicamentosInactivos()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Medicamentos");

            miComando.CommandText = "ListarMedicamentosInactivos";

            DataSet elMedicamento = new DataSet();
            this.abrirConexion();

            elMedicamento = this.seleccionarInformacion(miComando);
            DataTable miTabla = elMedicamento.Tables[0];

            return miTabla;
        }
        public string EliminarMedicamento(int Medicamento_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Medicamento");

            miComando.CommandText = "EliminarMedicamento";

            miComando.Parameters.Add("Medicamento_id", SqlDbType.Int);
            miComando.Parameters["Medicamento_id"].Value = Medicamento_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Medicamento";

            Console.WriteLine("Fin Gestor eliminar Medicamento");
            return respuesta;

        }
        public string InactivarMedicamento(int Medicamento_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Medicamento");

            miComando.CommandText = "InactivarMedicamento";

            miComando.Parameters.Add("Medicamento_id", SqlDbType.Int);
            miComando.Parameters["Medicamento_id"].Value = Medicamento_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Medicamento";

            Console.WriteLine("Fin Gestor Inactivar Medicamento");
            return respuesta;

        }
        public string ActivarMedicamento(int Medicamento_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor activar Medicamento");

            miComando.CommandText = "ActivarMedicamento";

            miComando.Parameters.Add("Medicamento_id", SqlDbType.Int);
            miComando.Parameters["Medicamento_id"].Value = Medicamento_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Medicamento";

            Console.WriteLine("Fin Gestor activar Medicamento");
            return respuesta;

        }


    }
}


  