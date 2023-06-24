using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.CapaLogica.LogicaNegocio
{
    public class Mascota
    {
        #region ATRIBUTOS
        protected int mascota_id;
        protected int especie_id;
        protected int duenno_id;
        protected string mascota_nombre;
        protected string mascota_genero;
        protected string mascota_color;
        protected string mascota_peso;
        protected string mascota_fechaNacimiento;
        protected string mascota_estado;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public Mascota()
        {

        }

        public Mascota(int Pespecie_id, int Pduenno_id, string Pmascota_nombre,
                       string Pmascota_genero, string Pmascota_color, string Pmascota_peso,
                       string Pmascota_fechaNacimiento, string Pmascota_estado
                                         )
        {
            Mascota_id = 0;
            Especie_id = Pespecie_id;
            Duenno_id = Pduenno_id;
            Mascota_nombre = Pmascota_nombre;
            Mascota_genero = Pmascota_genero;
            Mascota_color = Pmascota_color;
            Mascota_peso = Pmascota_peso;
            Mascota_fechaNacimiento = Pmascota_fechaNacimiento;
            Mascota_estado = Pmascota_estado;
         
        }

        public Mascota(int Pmascota_id,int Pespecie_id, int Pduenno_id, string Pmascota_nombre,
               string Pmascota_genero, string Pmascota_color, string Pmascota_peso,
               string Pmascota_fechaNacimiento, string Pmascota_estado
                                 )
        {
            Mascota_id = Pmascota_id;
            Especie_id = Pespecie_id;
            Duenno_id = Pduenno_id;
            Mascota_nombre = Pmascota_nombre;
            Mascota_genero = Pmascota_genero;
            Mascota_color = Pmascota_color;
            Mascota_peso = Pmascota_peso;
            Mascota_fechaNacimiento = Pmascota_fechaNacimiento;
            Mascota_estado = Pmascota_estado;

        }

        #endregion CONSTRUCTORES



        #region GET'S Y SET'S
        public int Mascota_id { get => mascota_id; set => mascota_id = value; }
        public int Especie_id { get => especie_id; set => especie_id = value; }
        public int Duenno_id { get => duenno_id; set => duenno_id = value; }
        public string Mascota_nombre { get => mascota_nombre; set => mascota_nombre = value; }
        public string Mascota_genero { get => mascota_genero; set => mascota_genero = value; }
        public string Mascota_color { get => mascota_color; set => mascota_color = value; }
        public string Mascota_peso { get => mascota_peso; set => mascota_peso = value; }
        public string Mascota_fechaNacimiento { get => mascota_fechaNacimiento; set => mascota_fechaNacimiento = value; }
        public string Mascota_estado { get => mascota_estado; set => mascota_estado = value; }
        #endregion GET'S Y SET'S





    }
}
