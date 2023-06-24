using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.CapaLogica.LogicaNegocio
{
    public class Expediente
    {
        #region ATRIBUTOS
        protected int expediente_id;
        protected int mascota_id;
        protected int veterinario_id;
        protected int tratamiento_id;
        protected string expediente_fecha;
        protected string expediente_estado;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public Expediente()
        {

        }
        public Expediente(int Pmascota_id, int Pveterinario_id,
                          int Ptratamiento_id, string Pexpediente_fecha, string Pexpediente_estado)
        {
            Expediente_id = 0;
            Mascota_id = Pmascota_id;
            Veterinario_id = Pveterinario_id;
            Tratamiento_id = Ptratamiento_id;
            Expediente_fecha = Pexpediente_fecha;
            Expediente_estado = Pexpediente_estado;
        }

        public Expediente(int Pexpediente_id, int Pmascota_id, int Pveterinario_id,
                    int Ptratamiento_id, string Pexpediente_fecha, string Pexpediente_estado)
        {
            Expediente_id = Pexpediente_id;
            Mascota_id = Pmascota_id;
            Veterinario_id = Pveterinario_id;
            Tratamiento_id = Ptratamiento_id;
            Expediente_fecha = Pexpediente_fecha;
            Expediente_estado = Pexpediente_estado;
        }
        #endregion CONSTRUCTORES


        #region GET'S Y SET'S
        public int Expediente_id { get => expediente_id; set => expediente_id = value; }
        public int Mascota_id { get => mascota_id; set => mascota_id = value; }
        public int Veterinario_id { get => veterinario_id; set => veterinario_id = value; }
        public int Tratamiento_id { get => tratamiento_id; set => tratamiento_id = value; }
        public string Expediente_fecha { get => expediente_fecha; set => expediente_fecha = value; }
        public string Expediente_estado { get => expediente_estado; set => expediente_estado = value; }

        #endregion GET'S Y SET'S














    }
}
