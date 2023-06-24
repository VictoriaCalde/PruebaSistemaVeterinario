using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.CapaLogica.LogicaNegocio
{
    public class Duenno
    {
        #region ATRIBUTOS
        protected int duenno_id;
        protected int duenno_cedula;
        protected string duenno_nombre;
        protected string duenno_apellido;
        protected string duenno_telefono;
        protected string duenno_direccion;
        protected string duenno_estado;

       

        #endregion


        #region CONSTRUCTORES
        public Duenno()
        {

        }
        /// <summary>
        /// Manejo  procedimiento almacenado  insertar Duenno
        /// </summary>
        /// <param name="Pduenno_cedula"></param>
        /// <param name="Pduenno_nombre"></param>
        /// <param name="Pduenno_apellido"></param>
        /// <param name="Pduenno_telefono"></param>
        /// <param name="Pduenno_direccion"></param>
        /// <param name="Pduenno_estado"></param>
        public Duenno (int Pduenno_cedula,string Pduenno_nombre, string Pduenno_apellido,
                       string Pduenno_telefono, string Pduenno_direccion, string Pduenno_estado)
        {
            Duenno_id = 0;
            Duenno_cedula = Pduenno_cedula;
            Duenno_nombre = Pduenno_nombre;
            Duenno_apellido = Pduenno_apellido;
            Duenno_telefono = Pduenno_telefono;
            Duenno_direccion = Pduenno_direccion;
            Duenno_estado = Pduenno_estado;
        }

        /// <summary>
        /// Manejp de procedimientos almacenado de Modificar Duenno
        /// </summary>
        /// <param name="Pduenno_id"></param>
        /// <param name="Pduenno_cedula"></param>
        /// <param name="Pduenno_nombre"></param>
        /// <param name="Pduenno_apellido"></param>
        /// <param name="Pduenno_telefono"></param>
        /// <param name="Pduenno_direccion"></param>
        /// <param name="Pduenno_estado"></param>
        public Duenno(int Pduenno_id, int Pduenno_cedula, string Pduenno_nombre, string Pduenno_apellido,
               string Pduenno_telefono, string Pduenno_direccion, string Pduenno_estado)
        {
       
            Duenno_id = Pduenno_id;
            Duenno_cedula = Pduenno_cedula;
            Duenno_nombre = Pduenno_nombre;
            Duenno_apellido = Pduenno_apellido;
            Duenno_telefono = Pduenno_telefono;
            Duenno_direccion = Pduenno_direccion;
            Duenno_estado = Pduenno_estado;
        }

        #endregion CONSTRUCTORES

        #region GET's y SET's
        public int Duenno_id { get => duenno_id; set => duenno_id = value; }
        public int Duenno_cedula { get => duenno_cedula; set => duenno_cedula = value; }
        public string Duenno_nombre { get => duenno_nombre; set => duenno_nombre = value; }
        public string Duenno_apellido { get => duenno_apellido; set => duenno_apellido = value; }
        public string Duenno_telefono { get => duenno_telefono; set => duenno_telefono = value; }
        public string Duenno_direccion { get => duenno_direccion; set => duenno_direccion = value; }
        public string Duenno_estado { get => duenno_estado; set => duenno_estado = value; }


        #endregion GET's y SET's


    }
}