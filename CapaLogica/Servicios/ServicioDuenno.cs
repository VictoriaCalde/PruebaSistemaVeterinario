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
    public class ServicioDuenno:servicio,IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }

        public ServicioDuenno()
        {
            respuesta = " ";
            miComando = new SqlCommand();
        }

        public string InsertarDuenno(Duenno elDuenno)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InsertarDuenno");

            miComando.CommandText = "InsertarDuenno";

            miComando.Parameters.Add("Duenno_cedula", SqlDbType.Int);
            miComando.Parameters["Duenno_cedula"].Value = elDuenno.Duenno_cedula;

            miComando.Parameters.Add("Duenno_nombre", SqlDbType.VarChar);
            miComando.Parameters["Duenno_nombre"].Value = elDuenno.Duenno_nombre;

            miComando.Parameters.Add("Duenno_apellido", SqlDbType.VarChar);
            miComando.Parameters["Duenno_apellido"].Value = elDuenno.Duenno_apellido;

            miComando.Parameters.Add("Duenno_telefono", SqlDbType.VarChar);
            miComando.Parameters["Duenno_telefono"].Value = elDuenno.Duenno_telefono;

            miComando.Parameters.Add("Duenno_direccion", SqlDbType.VarChar);
            miComando.Parameters["Duenno_direccion"].Value = elDuenno.Duenno_direccion;

            miComando.Parameters.Add("Duenno_estado", SqlDbType.VarChar);
            miComando.Parameters["Duenno_estado"].Value = elDuenno.Duenno_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion insertar duenno";
                Console.WriteLine("Fin Servicio insertar duenno");
            return respuesta;
        }

        public string ModificarDuenno(Duenno elDuenno)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ModificarDuenno");

            miComando.CommandText = "ModificarDuenno";

            miComando.Parameters.Add("Duenno_id", SqlDbType.Int);
            miComando.Parameters["Duenno_id"].Value = elDuenno.Duenno_id;

            miComando.Parameters.Add("Duenno_cedula", SqlDbType.Int);
            miComando.Parameters["Duenno_cedula"].Value = elDuenno.Duenno_cedula;

            miComando.Parameters.Add("Duenno_nombre", SqlDbType.VarChar);
            miComando.Parameters["Duenno_nombre"].Value = elDuenno.Duenno_nombre;

            miComando.Parameters.Add("Duenno_apellido", SqlDbType.VarChar);
            miComando.Parameters["Duenno_apellido"].Value = elDuenno.Duenno_apellido;

            miComando.Parameters.Add("Duenno_telefono", SqlDbType.VarChar);
            miComando.Parameters["Duenno_telefono"].Value = elDuenno.Duenno_telefono;

            miComando.Parameters.Add("Duenno_direccion", SqlDbType.VarChar);
            miComando.Parameters["Duenno_direccion"].Value = elDuenno.Duenno_direccion;

            miComando.Parameters.Add("Duenno_estado", SqlDbType.VarChar);
            miComando.Parameters["Duenno_estado"].Value = elDuenno.Duenno_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion modificar duenno";
            Console.WriteLine("Fin Servicio modificar duenno");

            return respuesta;
        }


        public DataSet ConsultarDuenno( int Duenno_id)   //devuelve un registro del duenno que buscamos mediante el id
        {
            miComando.CommandText = "ConsultarDuenno";
            miComando.Parameters.AddWithValue("@Duenno_id", SqlDbType.Int);
            miComando.Parameters["@Duenno_id"].Value = Duenno_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarDuennos() //devuelve todos los registros de la BD
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Duenno");

            miComando.CommandText = "ListarDuennos";

            DataSet elDuenno = new DataSet();
            this.abrirConexion();

            elDuenno = this.seleccionarInformacion(miComando);
            DataTable miTabla = elDuenno.Tables[0];

            return miTabla; 
        }
        public DataTable ListarDuennosInactivos() //devuelve todos los registros de la BD
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Duenno Inactivos");

            miComando.CommandText = "ListarDuennosInactivos";

            DataSet elDuenno = new DataSet();
            this.abrirConexion();

            elDuenno = this.seleccionarInformacion(miComando);
            DataTable miTabla = elDuenno.Tables[0];

            return miTabla;
        }
        public string EliminarDuenno(int Duenno_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Duenno");

            miComando.CommandText = "EliminarDuenno";

            miComando.Parameters.Add("Duenno_id", SqlDbType.Int);
            miComando.Parameters["Duenno_id"].Value = Duenno_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Duenno";

            Console.WriteLine("Fin Gestor Eliminar Duenno");
            return respuesta;

        }
        public string InactivarDuenno(int Duenno_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Duenno");

            miComando.CommandText = "InactivarDuenno";

            miComando.Parameters.Add("Duenno_id", SqlDbType.Int);
            miComando.Parameters["Duenno_id"].Value = Duenno_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Duenno";

            Console.WriteLine("Fin Gestor Inactivar Duenno");
            return respuesta;

        }

        public string ActivarDuenno(int Duenno_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Duenno");

            miComando.CommandText = "ActivarDuenno";

            miComando.Parameters.Add("Duenno_id", SqlDbType.Int);
            miComando.Parameters["Duenno_id"].Value = Duenno_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion activar Duenno";

            Console.WriteLine("Fin Gestor activar Duenno");
            return respuesta;

        }

    }
}