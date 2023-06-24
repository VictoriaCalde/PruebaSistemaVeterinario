using System;
using System.Collections.Generic;
using System.Data;
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
    public class ServicioUsuario : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;
        SqlDataAdapter reader ;

        public void Dispose()
        {

        }
        public ServicioUsuario()
        {
            respuesta = " ";
            miComando = new SqlCommand();
        }

        public string InsertarUsuario(Usuario elUsuario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Usuario");

            miComando.CommandText = "InsertarUsuario";

            miComando.Parameters.Add("Usuario_nombre", SqlDbType.VarChar);
            miComando.Parameters["Usuario_nombre"].Value = elUsuario.Usuario_nombre;

            miComando.Parameters.Add("Usuario_contrasenna", SqlDbType.VarChar);
            miComando.Parameters["Usuario_contrasenna"].Value = elUsuario.Usuario_contrasenna;

            miComando.Parameters.Add("Usuario_tipo", SqlDbType.VarChar);
            miComando.Parameters["Usuario_tipo"].Value = elUsuario.Usuario_tipo;

            miComando.Parameters.Add("Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["Usuario_estado"].Value = elUsuario.Usuario_estado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion insertar usuario";
            Console.WriteLine("Fin Gestor insertar usuario");
            return respuesta;
        }

        public string ModificarUsuario(Usuario elUsuario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Usuario");

            miComando.CommandText = "ModificarUsuario";

            miComando.Parameters.Add("Usuario_id", SqlDbType.Int);
            miComando.Parameters["Usuario_id"].Value = elUsuario.Usuario_id;

            miComando.Parameters.Add("Usuario_nombre", SqlDbType.VarChar);
            miComando.Parameters["Usuario_nombre"].Value = elUsuario.Usuario_nombre;

            miComando.Parameters.Add("Usuario_contrasenna", SqlDbType.VarChar);
            miComando.Parameters["Usuario_contrasenna"].Value = elUsuario.Usuario_contrasenna;

            miComando.Parameters.Add("Usuario_tipo", SqlDbType.VarChar);
            miComando.Parameters["Usuario_tipo"].Value = elUsuario.Usuario_tipo;

            miComando.Parameters.Add("Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["Usuario_estado"].Value = elUsuario.Usuario_estado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Modificar usuario";
            Console.WriteLine("Fin Gestor Modificar usuario");
            return respuesta;
        }
        public bool ConsultarUsuario(string usua, string conta)
        {
            miComando.CommandText = "ConsultarUsuario";

            miComando.Parameters.AddWithValue("@Usuario_tipo", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_tipo"].Value = usua;

            miComando.Parameters.AddWithValue("@Usuario_contrasenna", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_contrasenna"].Value = conta;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Modificar usuario";
            Console.WriteLine("Fin Gestor Modificar usuario");
            return true;
        }

        public DataTable ListarUsuarios()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Usuarios");

            miComando.CommandText = "ListarUsuarios";

            DataSet elUsuarios = new DataSet();
            this.abrirConexion();

            elUsuarios = this.seleccionarInformacion(miComando);
            DataTable miTabla = elUsuarios.Tables[0];

            return miTabla;
        }
        public string EliminarUsuario(int Usuario_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Usuario");

            miComando.CommandText = "EliminarUsuario";

            miComando.Parameters.Add("Usuario_id", SqlDbType.Int);
            miComando.Parameters["Usuario_id"].Value = Usuario_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Eliminar Usuario";

            Console.WriteLine("Fin Gestor eliminar Usuario");
            return respuesta;

        }
        public string InactivarUsuario(int Usuario_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Usuario");

            miComando.CommandText = "InactivarUsuario";

            miComando.Parameters.Add("Usuario_id", SqlDbType.Int);
            miComando.Parameters["Usuario_id"].Value = Usuario_id;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == " ")
                respuesta += "Se  ha realizado correctamente la transaccion Inactivar Usuario";

            Console.WriteLine("Fin Gestor InactivarUsuario");
            return respuesta;

        }

















    
}}
