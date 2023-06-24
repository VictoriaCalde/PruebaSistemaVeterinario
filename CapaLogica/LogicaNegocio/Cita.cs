using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.CapaLogica.LogicaNegocio
{
    #region ATRIBUTOS
    public class Cita
    {
        #region ATRIBUTOS
        protected int cita_id;
        protected int mascota_id;
        protected int veterinario_id;
        protected string cita_hora;
        protected string cita_fecha;
        protected string cita_estado;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public Cita()
        {

        }

        public Cita(int Pmascota_id, int Pveterinario_id,
                   string Pcita_hora, string Pcita_fecha,string Pcita_estado)
        {
            Cita_id =0;
            Mascota_id = Pmascota_id;
            Veterinario_id= Pveterinario_id;
            Cita_hora = Pcita_hora;
            Cita_fecha = Pcita_fecha;
            Cita_estado = Pcita_estado; 

        }
        public Cita(int Pcita_id, int Pmascota_id, int Pveterinario_id,
           string Pcita_hora, string Pcita_fecha, string Pcita_estado)
        {
            Cita_id = Pcita_id;
            Mascota_id = Pmascota_id;
            Veterinario_id = Pveterinario_id;
            Cita_hora = Pcita_hora;
            Cita_fecha = Pcita_fecha;
            Cita_estado = Pcita_estado;

        }
        #endregion CONSTRUCTORES


       // #region GET's y SET's
       public int Cita_id { get => cita_id; set => cita_id = value; }
       public int Mascota_id { get => mascota_id; set => mascota_id = value; }
       public int Veterinario_id { get => veterinario_id; set => veterinario_id = value; }
       public string Cita_hora { get => cita_hora; set => cita_hora = value; }
       public string Cita_fecha { get => cita_fecha; set => cita_fecha = value; }
       public string Cita_estado { get => cita_estado; set => cita_estado = value; }
        #endregion GET's y SET's



    }
}