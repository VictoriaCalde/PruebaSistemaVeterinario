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
    public class ServicioMascota : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }
        public ServicioMascota()
        {
            respuesta = " ";
            miComando = new SqlCommand();
        }
        public string InsertarMascota(Mascota laMascota)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InsertarMascota");

            miComando.CommandText = "InsertarMascota";

            miComando.Parameters.Add("Especie_id", SqlDbType.Int);
            miComando.Parameters["Especie_id"].Value = laMascota.Especie_id;


            miComando.Parameters.Add("Duenno_id", SqlDbType.Int);
            miComando.Parameters["Duenno_id"].Value = laMascota.Duenno_id;

            miComando.Parameters.Add("Mascota_nombre", SqlDbType.VarChar);
            miComando.Parameters["Mascota_nombre"].Value = laMascota.Mascota_nombre;

            miComando.Parameters.Add("Mascota_genero", SqlDbType.VarChar);
            miComando.Parameters["Mascota_genero"].Value = laMascota.Mascota_genero;


            miComando.Parameters.Add("Mascota_color", SqlDbType.VarChar);
            miComando.Parameters["Mascota_color"].Value = laMascota.Mascota_color;


            miComando.Parameters.Add("Mascota_peso", SqlDbType.VarChar);
            miComando.Parameters["Mascota_peso"].Value = laMascota.Mascota_peso;


            miComando.Parameters.Add("Mascota_fechaNacimiento", SqlDbType.VarChar);
            miComando.Parameters["Mascota_fechaNacimiento"].Value = laMascota.Mascota_fechaNacimiento;


            miComando.Parameters.Add("Mascota_estado", SqlDbType.VarChar);
            miComando.Parameters["Mascota_estado"].Value = laMascota.Mascota_estado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion insertar Mascota";
            Console.WriteLine("Fin Gestor insertar Mascota");
            return respuesta;
        }

        public string ModificarMascota(Mascota laMascota)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Mascota");

            miComando.CommandText = "ModificarMascota";

            miComando.Parameters.Add("Mascota_id", SqlDbType.Int);
            miComando.Parameters["Mascota_id"].Value = laMascota.Mascota_id;


            miComando.Parameters.Add("Especie_id", SqlDbType.Int);
            miComando.Parameters["Especie_id"].Value = laMascota.Especie_id;


            miComando.Parameters.Add("Duenno_id", SqlDbType.Int);
            miComando.Parameters["Duenno_id"].Value = laMascota.Duenno_id;

            miComando.Parameters.Add("Mascota_nombre", SqlDbType.VarChar);
            miComando.Parameters["Mascota_nombre"].Value = laMascota.Mascota_nombre;

            miComando.Parameters.Add("Mascota_genero", SqlDbType.VarChar);
            miComando.Parameters["Mascota_genero"].Value = laMascota.Mascota_genero;


            miComando.Parameters.Add("Mascota_color", SqlDbType.VarChar);
            miComando.Parameters["Mascota_color"].Value = laMascota.Mascota_color;


            miComando.Parameters.Add("Mascota_peso", SqlDbType.VarChar);
            miComando.Parameters["Mascota_peso"].Value = laMascota.Mascota_peso;


            miComando.Parameters.Add("Mascota_fechaNacimiento", SqlDbType.VarChar);
            miComando.Parameters["Mascota_fechaNacimiento"].Value = laMascota.Mascota_fechaNacimiento;


            miComando.Parameters.Add("Mascota_estado", SqlDbType.VarChar);
            miComando.Parameters["Mascota_estado"].Value = laMascota.Mascota_estado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Modificar Mascota";
            Console.WriteLine("Fin Gestor Modificar Mascota");
            return respuesta;
        }
        public DataSet ConsultarMascota(int Mascota_id)
        {
            miComando.CommandText = "ConsultarMascota";
            miComando.Parameters.AddWithValue("@Mascota_id", SqlDbType.Int);


            miComando.Parameters["@Mascota_id"].Value = Mascota_id;



            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarMascotas()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Mascotas");

            miComando.CommandText = "ListarMascotas";

            DataSet laMascotas = new DataSet();
            this.abrirConexion();

            laMascotas = this.seleccionarInformacion(miComando);
            DataTable miTabla = laMascotas.Tables[0];

            return miTabla;
        }
        public DataTable ListarMascotasInactivas()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Mascotas Inactivas");

            miComando.CommandText = "ListarMascotasInactivos";

            DataSet laMascotas = new DataSet();
            this.abrirConexion();

            laMascotas = this.seleccionarInformacion(miComando);
            DataTable miTabla = laMascotas.Tables[0];

            return miTabla;
        }
        public string EliminarMascota(int Mascota_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Mascota");

            miComando.CommandText = "EliminarMascota";

            miComando.Parameters.Add("Mascota_id", SqlDbType.Int);
            miComando.Parameters["Mascota_id"].Value = Mascota_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Mascota";

            Console.WriteLine("Fin Gestor eliminar Mascota");
            return respuesta;

        }
        public string InactivarMascota(int Mascota_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Mascota");

            miComando.CommandText = "InactivarMascota";

            miComando.Parameters.Add("Mascota_id", SqlDbType.Int);
            miComando.Parameters["Mascota_id"].Value = Mascota_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Mascota";

            Console.WriteLine("Fin Gestor Inactivar Mascota");
            return respuesta;

        }
        public string ActivarMascota(int Mascota_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor activar Mascota");

            miComando.CommandText = "ActivarMascota";

            miComando.Parameters.Add("Mascota_id", SqlDbType.Int);
            miComando.Parameters["Mascota_id"].Value = Mascota_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Mascota";

            Console.WriteLine("Fin Gestor activar Mascota");
            return respuesta;

        }



    }
}
