using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.CapaLogica.LogicaNegocio
{
    public class Medicamento
    {
        #region ATRIBUTOS
        protected int medicamento_id;
        protected string medicamento_nombre;
        protected string medicamento_dosis;
        protected string medicamento_estado;



        #endregion ATRIBUTOS


        #region CONSTRUCTORES
        public Medicamento()
        {

        }
        /// <summary>
        /// INSERTAR
        /// </summary>
        /// <param name="Pmedicamento_nombre"></param>
        /// <param name="Pmedicamento_dosis"></param>
        /// <param name="Pmedicamento_estado"></param>
        public Medicamento(string Pmedicamento_nombre, string Pmedicamento_dosis,
                       string Pmedicamento_estado)
        {
            Medicamento_id = 0;
            Medicamento_nombre = Pmedicamento_nombre;
            Medicamento_dosis = Pmedicamento_dosis;
            Medicamento_estado = Pmedicamento_estado;
        }

        
        /// <summary>
        ///  MODIFICAR
        /// </summary>
        /// <param name="Pmedicamento_id"></param>
        /// <param name="Pmedicamento_nombre"></param>
        /// <param name="Pmedicamento_dosis"></param>
        /// <param name="Pmedicamento_estado"></param>
        public Medicamento(int Pmedicamento_id, string Pmedicamento_nombre, string Pmedicamento_dosis,
                       string Pmedicamento_estado)
        {

            Medicamento_id = Pmedicamento_id;
            Medicamento_nombre = Pmedicamento_nombre;
            Medicamento_dosis = Pmedicamento_dosis;
            Medicamento_estado = Pmedicamento_estado;
        }

        #endregion CONSTRUCTORES



        #region GET's y SET's
        public int Medicamento_id { get => medicamento_id; set => medicamento_id = value; }
        public string Medicamento_nombre { get => medicamento_nombre; set => medicamento_nombre = value; }
        public string Medicamento_dosis { get => medicamento_dosis; set => medicamento_dosis = value; }
        public string Medicamento_estado { get => medicamento_estado; set => medicamento_estado = value; }
        #endregion GET's y SET's


    }
}
    


