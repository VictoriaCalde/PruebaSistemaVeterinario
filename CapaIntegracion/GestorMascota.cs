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
    public class GestorMascota : servicio, IDisposable

    {
        public GestorMascota()
        {

        }
        public void Dispose()
        {

        }
        public string InsertarMascota(int Especie_id, int Duenno_id, string Mascota_nombre,
                                        string Mascota_genero, string Mascota_color,string Mascota_peso,
                                        string Mascota_fecha_Nacimiento, string Mascota_estado )
        {
            Mascota nuevaMascota = new Mascota(Especie_id, Duenno_id, Mascota_nombre,
                                               Mascota_genero, Mascota_color, Mascota_peso,
                                               Mascota_fecha_Nacimiento, Mascota_estado);

                using (ServicioMascota laMascota = new ServicioMascota())
                return laMascota.InsertarMascota(nuevaMascota);
        }
        public string ModificarMascota(int Mascota_id, int Especie_id, int Duenno_id, string Mascota_nombre,
                                string Mascota_genero, string Mascota_color, string Mascota_peso,
                                string Mascota_fecha_Nacimiento, string Mascota_estado)
        {
            Mascota nuevaMascota = new Mascota(Mascota_id,Especie_id, Duenno_id, Mascota_nombre,
                                               Mascota_genero, Mascota_color, Mascota_peso,
                                               Mascota_fecha_Nacimiento, Mascota_estado);

            using (ServicioMascota laMascota = new ServicioMascota())
                return laMascota.ModificarMascota(nuevaMascota);
        }
        public DataSet ConsultarMascota(int Mascota_id)
        {
            using (ServicioMascota laMascota = new ServicioMascota())
            {
                return laMascota.ConsultarMascota(Mascota_id);
            }
        }
        public DataTable ListarMascotas()
        {
            using (ServicioMascota laMascota = new ServicioMascota())
            {
                return laMascota.ListarMascotas();
            }
        }
        public DataTable ListarMascotasInactivas()
        {
            using (ServicioMascota laMascota = new ServicioMascota())
            {
                return laMascota.ListarMascotasInactivas();
            }
        }


        public string EliminarMascota(int Mascota_id)
        {

            using (ServicioMascota laMascota = new ServicioMascota())
                return laMascota.EliminarMascota(Mascota_id);
        }
        public string InactivarMascota(int Mascota_id)
        {

            using (ServicioMascota laMascota = new ServicioMascota())
                return laMascota.InactivarMascota(Mascota_id);
        }
        public string ActivarMascota(int Mascota_id)
        {

            using (ServicioMascota laMascota = new ServicioMascota())
                return laMascota.ActivarMascota(Mascota_id);
        }

    }
}
