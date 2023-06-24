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
    public class GestorEspecie : servicio, IDisposable
    {

        public GestorEspecie()
        {

        }
        public void Dispose()
        {

        }

        public string InsertarEspecie(string Especie_descripcion, string Especie_estado)
        {
            Especie nuevaEspecie = new Especie(Especie_descripcion, Especie_estado);

            using (ServicioEspecie laEspecie = new ServicioEspecie())
                return laEspecie.InsertarEspecie(nuevaEspecie);
        }

        public string ModificarEspecie(int Especie_id, string Especie_descripcion, string Especie_estado)
        {
            Especie nuevaEspecie = new Especie(Especie_id,Especie_descripcion, Especie_estado);

            using (ServicioEspecie laEspecie = new ServicioEspecie())
                return laEspecie.ModificarEspecie(nuevaEspecie);
        }
        public DataSet ConsultarEspecie(int Especie_id)
        {
            using (ServicioEspecie laEspecie = new ServicioEspecie())
            {
                return laEspecie.ConsultarEspecie(Especie_id);
            }
        }

        public DataTable ListarEspecies()
        {
            using (ServicioEspecie laEspecie = new ServicioEspecie())
            {
                return laEspecie.ListarEspecies();
            }
        }
        public DataTable ListarEspeciesInactivas()
        {
            using (ServicioEspecie laEspecie = new ServicioEspecie())
            {
                return laEspecie.ListarEspeciesInactivas();
            }
        }
        public string EliminarEspecie(int Especie_id)
        {
            using (ServicioEspecie laEspecie = new ServicioEspecie())
                return laEspecie.EliminarEspecie (Especie_id);
        }
        public string InactivarEspecie(int Especie_id)
        {
            using (ServicioEspecie laEspecie = new ServicioEspecie())
                return laEspecie.InactivarEspecie(Especie_id);
        }
        public string ActivarEspecie(int Especie_id)
        {
            using (ServicioEspecie laEspecie = new ServicioEspecie())
                return laEspecie.ActivarEspecie(Especie_id);
        }


    }
}
