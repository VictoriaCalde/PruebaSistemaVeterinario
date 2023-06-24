using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.CapaLogica.LogicaNegocio
{
   public class Usuario
   {
       #region ATRIBUTOS
       protected int usuario_id;
       protected string usuario_nombre;
       protected string usuario_contrasenna;
       protected string usuario_tipo;
       protected string usuario_estado;
       #endregion ATRIBUTOS
  
       #region CONSTRUCTORES
       public Usuario()
       {
  
       }
        public Usuario(string Pusuario_nombre, string Pusuario_contrasenna,
                       string Pusuario_tipo, string Pusuario_estado)
        {
            Usuario_id = 0;
            Usuario_nombre = Pusuario_nombre;
            Usuario_contrasenna = Pusuario_contrasenna;
            Usuario_tipo = Pusuario_tipo;
            Usuario_estado = Pusuario_estado;
        }
        //
        public Usuario(int Pusuario_id, string Pusuario_nombre, string Pusuario_contrasenna,
               string Pusuario_tipo, string Pusuario_estado)
        {
            Usuario_id = Pusuario_id;
            Usuario_nombre = Pusuario_nombre;
            Usuario_contrasenna = Pusuario_contrasenna;
            Usuario_tipo = Pusuario_tipo;
            Usuario_estado = Pusuario_estado;
        }
        //
        //
        //
        //
           #endregion CONSTRUCTORES
           #region GET'S Y SET'S
           public int Usuario_id { get => usuario_id; set => usuario_id = value; }
           public string Usuario_nombre { get => usuario_nombre; set => usuario_nombre = value; }
           public string Usuario_contrasenna { get => usuario_contrasenna; set => usuario_contrasenna = value; }
           public string Usuario_tipo { get => usuario_tipo; set => usuario_tipo = value; }
           public string Usuario_estado { get => usuario_estado; set => usuario_estado = value; }
       
       
           #endregion GET'S Y SET'S
       
       



        //   }
    }
}
