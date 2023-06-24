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
    public class GestorCita: servicio, IDisposable
    {
        public GestorCita()
        {

        }
        public void Dispose()
        {

        }
        //metodo para enlazar la interfaz presentacion y capa logica

        public string InsertarCita(int Mascota_id,int Veterinario_id,string Cita_hora,
                                    string Cita_fecha, string Cita_estado
                                )
        {
            Cita nuevaCita = new Cita(Mascota_id,Veterinario_id,Cita_hora,
                                        Cita_fecha, Cita_estado);


            using (ServicioCita laCita = new ServicioCita())
                return laCita.InsertarCita(nuevaCita);
        }

        public string ModificarCita(int Cita_id, int Mascota_id, int Veterinario_id, string Cita_hora,
                            string Cita_fecha, string Cita_estado
                        )
        {
            Cita nuevaCita = new Cita(Cita_id, Mascota_id, Veterinario_id, Cita_hora,
                                        Cita_fecha, Cita_estado);


            using (ServicioCita laCita = new ServicioCita())
                return laCita.ModificarCita(nuevaCita);
        }

        public DataSet ConsultarCita(int Cita_id)
        {
            using (ServicioCita laCita = new ServicioCita())
            {
                return laCita.ConsultarCita(Cita_id);
            }
        }

        public DataTable ListarCitas()
        {
            using (ServicioCita laCita = new ServicioCita())
            {
                return laCita.ListarCitas();
            }
        }
        public DataTable ListarCitasInactivas()
        {
            using (ServicioCita laCita = new ServicioCita())
            {
                return laCita.ListarCitasInactivas();
            }
        }

        public string EliminarCita(int Cita_id)
        {

            using (ServicioCita laCita = new ServicioCita())
                return laCita.EliminarCita(Cita_id);
        }
        public string InactivarCita(int Cita_id)
        {

            using (ServicioCita laCita = new ServicioCita())
                return laCita.InactivarCita(Cita_id);
        }

        public string ActivarCita(int Cita_id)
        {

            using (ServicioCita laCita = new ServicioCita())
                return laCita.ActivarCita(Cita_id);
        }





    }

}
