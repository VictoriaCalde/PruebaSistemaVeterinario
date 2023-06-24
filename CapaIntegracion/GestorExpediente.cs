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
    public class GestorExpediente : servicio, IDisposable
    {
        public GestorExpediente()
        {

        }
        public void Dispose()
        {

        }

        public string InsertarExpediente(int Mascota_id, int Veterinario_id, int Tratamiento_id,
                                         string Expediente_fecha, string Expediente_estado)
        {
            Expediente nuevoExpediente = new Expediente(Mascota_id,Veterinario_id,Tratamiento_id,
                                                        Expediente_fecha,Expediente_estado);


            using (ServicioExpediente elExpediente = new ServicioExpediente())
                return elExpediente.InsertarExpediente(nuevoExpediente);
        }


        public string ModificarExpediente(int Expediente_id, int Mascota_id, int Veterinario_id, int Tratamiento_id,
                                 string Expediente_fecha, string Expediente_estado)
        {
            Expediente nuevoExpediente = new Expediente(Expediente_id, Mascota_id, Veterinario_id, Tratamiento_id,
                                                        Expediente_fecha, Expediente_estado);


            using (ServicioExpediente elExpediente = new ServicioExpediente())
                return elExpediente.ModificarExpediente(nuevoExpediente);
        }

        public DataSet ConsultarExpediente(int Expediente_id)
        {
            using (ServicioExpediente elExpediente = new ServicioExpediente())
            {
                return elExpediente.ConsultarExpediente(Expediente_id);
            }
        }

        public DataTable ListarExpedientes()
        {
            using (ServicioExpediente elExpediente = new ServicioExpediente())
            {
                return elExpediente.ListarExpedientes();
            }
        }
        public DataTable ListarExpedientesInactivos()
        {
            using (ServicioExpediente elExpediente = new ServicioExpediente())
            {
                return elExpediente.ListarExpedientesInactivos();
            }
        }

        public string EliminarExpediente(int Expediente_id)
        {

            using (ServicioExpediente elExpediente = new ServicioExpediente())
                return elExpediente.EliminarExpediente(Expediente_id);
        }
        public string InactivarExpediente(int Expediente_id)
        {

            using (ServicioExpediente elExpediente = new ServicioExpediente())
                return elExpediente.InactivarExpediente(Expediente_id);
        }
        public string ActivarExpediente(int Expediente_id)
        {

            using (ServicioExpediente elExpediente = new ServicioExpediente())
                return elExpediente.ActivarExpediente(Expediente_id);
        }



    }
}
