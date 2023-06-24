using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.CapaLogica.LogicaNegocio
{
    public class Veterinario
    {
        #region ATRIBUTOS
        protected int    veterinario_id;
        protected int    veterinario_cedula;
        protected string veterinario_nombre;
        protected string veterinario_telefono;
        protected string veterinario_direccion;
        protected string veterinario_estado;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public Veterinario()
        {



        }

        public Veterinario(int Pveterinario_cedula, string Pveterinario_nombre,
                          string Pveterinario_telefono, string Pveterinario_direccion, string Pveterinario_estado)
        {
            Veterinario_id =0;
            Veterinario_cedula = Pveterinario_cedula;
            Veterinario_nombre = Pveterinario_nombre;
            Veterinario_telefono = Pveterinario_telefono;
            Veterinario_direccion = Pveterinario_direccion;
            Veterinario_estado = Pveterinario_estado;
             
        }

        public Veterinario(int Pveterinario_id, int Pveterinario_cedula, string Pveterinario_nombre,
                  string Pveterinario_telefono, string Pveterinario_direccion, string Pveterinario_estado)
        {
            Veterinario_id = Pveterinario_id;
            Veterinario_cedula = Pveterinario_cedula;
            Veterinario_nombre = Pveterinario_nombre;
            Veterinario_telefono = Pveterinario_telefono;
            Veterinario_direccion = Pveterinario_direccion;
            Veterinario_estado = Pveterinario_estado;

        }
        #endregion CONSTRUCTORES


        #region GET'S Y SET'S
        public int Veterinario_id { get => veterinario_id; set => veterinario_id = value; }
       public int Veterinario_cedula { get => veterinario_cedula; set => veterinario_cedula = value; }
       public string Veterinario_nombre { get => veterinario_nombre; set => veterinario_nombre = value; }
       public string Veterinario_telefono { get => veterinario_telefono; set => veterinario_telefono = value; }
       public string Veterinario_direccion { get => veterinario_direccion; set => veterinario_direccion = value; }
       public string Veterinario_estado { get => veterinario_estado; set => veterinario_estado = value; }

        #endregion GET'S Y SET'S








    }
}
