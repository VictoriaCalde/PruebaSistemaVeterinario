using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVeterinario.CapaLogica.LogicaNegocio;
using SistemaVeterinario.CapaLogica.Servicios;
using SistemaVeterinario.CapaConexion;
using System.Data;

namespace SistemaVeterinario.CapaIntegracion
{
    public class GestorUsuario : servicio, IDisposable 
    {

        public GestorUsuario()
        {

        }
        public void Dispose()
        {

        }
        public string InsertarUsuario(string Usuario_nombre, string Usuario_contrasenna,
                                       string Usuario_tipo, string Usuario_estado)
        {
            Usuario nuevoUsuario = new Usuario(Usuario_nombre, Usuario_contrasenna,
                                               Usuario_tipo,Usuario_estado);
            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.InsertarUsuario(nuevoUsuario);
        }
        public string ModificarUsuario(int Usuario_id, string Usuario_nombre, string Usuario_contrasenna,
                               string Usuario_tipo, string Usuario_estado)
        {
            Usuario nuevoUsuario = new Usuario(Usuario_id,Usuario_nombre, Usuario_contrasenna,
                                               Usuario_tipo, Usuario_estado);
            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.ModificarUsuario(nuevoUsuario);
        }

 //     public DataSet ConsultarUsuario(string Usuario_nombre, string Usuario_contrasenna)
 //     {
 //         using (ServicioUsuario elUsuario = new ServicioUsuario())
 //         {
 //             return elUsuario.ConsultarUsuario(Usuario_nombre,Usuario_contrasenna);
 //         }
 //     }

        public bool login(string usuario, string contra)
        {
            using (ServicioUsuario elUsuario = new ServicioUsuario())
            {
                return elUsuario.ConsultarUsuario(usuario,contra);
            }
        }


        public DataTable ListarUsuarios()
        {
            using (ServicioUsuario elUsuario = new ServicioUsuario())
            {
                return elUsuario.ListarUsuarios();
            }
        }
        public string EliminarUsuario(int Usuario_id)
        {

            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.EliminarUsuario(Usuario_id);
        }
        public string InactivarUsuario(int Usuario_id)
        {

            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.InactivarUsuario(Usuario_id);
        }



    }
}
