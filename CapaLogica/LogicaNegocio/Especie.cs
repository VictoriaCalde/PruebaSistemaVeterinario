using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.CapaLogica.LogicaNegocio
{
    public class Especie
    {
        #region ATRIBUTOS
        protected int especie_id;
        protected string especie_descripcion;
        protected string especie_estado;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public Especie()
        {

        }
        public Especie(string Pespecie_descripcion,
                        string Pespecie_estado)
        {
            Especie_id = 0;
            Especie_descripcion = Pespecie_descripcion;
            Especie_estado = Pespecie_estado;

        }
        public Especie(int Pespecie_id, string Pespecie_descripcion,
                        string Pespecie_estado)
        {
            Especie_id = Pespecie_id;
            Especie_descripcion = Pespecie_descripcion;
            Especie_estado = Pespecie_estado;

        }
        #endregion CONSTRUCTORES


        #region GET'S Y SET'S
        public int Especie_id { get => especie_id; set => especie_id = value; }
        public string Especie_descripcion { get => especie_descripcion; set => especie_descripcion = value; }
        public string Especie_estado { get => especie_estado; set => especie_estado = value; }
      
        #endregion GET'S Y SET'S







    }
}
