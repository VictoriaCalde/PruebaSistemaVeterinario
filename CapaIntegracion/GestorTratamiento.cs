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
    public class GestorTratamiento : servicio, IDisposable
    {
        public GestorTratamiento()
        {

        }
        public void Dispose()
        {

        }
        public string InsertarTratamiento(int Medicamento_id, string Tratamiento_dosis,
                                            string Tratamiento_observaciones, string Tratamiento_estado)
        {
            Tratamiento nuevoTratamiento = new Tratamiento(Medicamento_id, Tratamiento_dosis,
                                                            Tratamiento_observaciones, Tratamiento_estado);

            using (ServicioTratamiento elTratamiento = new ServicioTratamiento())
                return elTratamiento.InsertarTratamiento(nuevoTratamiento);

        }

        public string ModificarTratamiento(int Tratamiento_id,int Medicamento_id, string Tratamiento_dosis,
                                    string Tratamiento_observaciones, string Tratamiento_estado)
        {
            Tratamiento nuevoTratamiento = new Tratamiento(Tratamiento_id,Medicamento_id, Tratamiento_dosis,
                                                            Tratamiento_observaciones, Tratamiento_estado);

            using (ServicioTratamiento elTratamiento = new ServicioTratamiento())
                return elTratamiento.ModificarTratamiento(nuevoTratamiento);
        }
        public DataSet ConsultarTratamiento(int Tratamiento_id)
        {
            using (ServicioTratamiento elTratamiento = new ServicioTratamiento())
            {
                return elTratamiento.ConsultarTratamiento(Tratamiento_id);
            }
        }
        public DataTable ListarTratamientos()
        {
            using (ServicioTratamiento elTratamiento = new ServicioTratamiento())
            {
                return elTratamiento.ListarTratamientos();
            }
        }
        public DataTable ListarTratamientosInactivos()
        {
            using (ServicioTratamiento elTratamiento = new ServicioTratamiento())
            {
                return elTratamiento.ListarTratamientosInactivos();
            }
        }
        public string EliminarTratamiento(int Tratamiento_id)
        {

            using (ServicioTratamiento elTratamiento = new ServicioTratamiento())
                return elTratamiento.EliminarTratamiento(Tratamiento_id);
        }
        public string InactivarTratamiento(int Tratamiento_id)
        {

            using (ServicioTratamiento elTratamiento = new ServicioTratamiento())
                return elTratamiento.InactivarTratamiento(Tratamiento_id);
        }
        public string ActivarTratamiento(int Tratamiento_id)
        {

            using (ServicioTratamiento elTratamiento = new ServicioTratamiento())
                return elTratamiento.ActivarTratamiento(Tratamiento_id);
        }









    }
}
