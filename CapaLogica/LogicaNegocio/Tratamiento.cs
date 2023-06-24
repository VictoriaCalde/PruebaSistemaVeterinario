                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.CapaLogica.LogicaNegocio
{
    public class Tratamiento
    {
        #region ATRIBUTOS
        protected int tratamiento_id;
        protected int medicamento_id;
        protected string tratamiento_dosis;
        protected string tratamiento_observaciones;
        protected string tratamiento_estado;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public Tratamiento()
        {

        }

        /// <summary>
        /// insertar
        /// </summary>
        /// <param name="Pmedicamento_id"></param>
        /// <param name="Ptratamiento_dosis"></param>
        /// <param name="Ptratamiento_observaciones"></param>
        /// <param name="Ptratamiento_estado"></param>
        public Tratamiento(int Pmedicamento_id, string Ptratamiento_dosis,
                      string Ptratamiento_observaciones, string Ptratamiento_estado)
        {
            Tratamiento_id = 0;
            Medicamento_id = Pmedicamento_id;
            Tratamiento_dosis = Ptratamiento_dosis;
            Tratamiento_observaciones = Ptratamiento_observaciones;
            Tratamiento_estado = Ptratamiento_estado;
        }



        public Tratamiento(int Ptratamiento_id, int Pmedicamento_id, string Ptratamiento_dosis,
                              string Ptratamiento_observaciones, string Ptratamiento_estado)
        {
            Tratamiento_id = Ptratamiento_id;
            Medicamento_id = Pmedicamento_id;
            Tratamiento_dosis = Ptratamiento_dosis;
            Tratamiento_estado = Ptratamiento_estado;
        }
        #endregion CONSTRUCTORES



        #region GET's y SET's
        public int Tratamiento_id { get => tratamiento_id; set => tratamiento_id = value; }
        public int Medicamento_id { get => medicamento_id; set => medicamento_id = value; }
        public string Tratamiento_dosis { get => tratamiento_dosis; set => tratamiento_dosis = value; }
        public string Tratamiento_observaciones { get => tratamiento_observaciones; set => tratamiento_observaciones = value; }
        public string Tratamiento_estado { get => tratamiento_estado; set => tratamiento_estado = value; }
        #endregion GET's y SET's

    }

}
