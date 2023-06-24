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
    public class GestorMedicamento : servicio, IDisposable
    {
        public GestorMedicamento()
        {

        }
        public void Dispose()
        {

        }
        public string InsertarMedicamento(string Medicamento_nombre, string Medicamento_dosis,
                                          string Medicamento_estado)
        {
            Medicamento nuevoMedicamento = new Medicamento(Medicamento_nombre, Medicamento_dosis, Medicamento_estado);

            using (ServicioMedicamento elMedicamento = new ServicioMedicamento())
                return elMedicamento.InsertarMedicamento(nuevoMedicamento);
        }

        public string ModificarMedicamento(int Medicamento_id, string Medicamento_nombre, string Medicamento_dosis,
                                  string Medicamento_estado)
        {
            Medicamento nuevoMedicamento = new Medicamento(Medicamento_id,Medicamento_nombre, Medicamento_dosis, Medicamento_estado);

            using (ServicioMedicamento elMedicamento = new ServicioMedicamento())
                return elMedicamento.ModificarMedicamento(nuevoMedicamento);
        }
        public DataSet ConsultarMedicamento(int Medicamento_id)
        {
            using (ServicioMedicamento elMedicamento = new ServicioMedicamento())
            {
                return elMedicamento.ConsultarMedicamento(Medicamento_id);
            }
        }
        public DataTable ListarMedicamentos()
        {
            using (ServicioMedicamento elMedicamento = new ServicioMedicamento())
            {
                return elMedicamento.ListarMedicamentos();
            }
        }
        public DataTable ListarMedicamentosInactivos()
        {
            using (ServicioMedicamento elMedicamento = new ServicioMedicamento())
            {
                return elMedicamento.ListarMedicamentosInactivos();
            }
        }
        public string EliminarMedicamento(int Medicamento_id)
        {

            using (ServicioMedicamento elMedicamento = new ServicioMedicamento())
                return elMedicamento.EliminarMedicamento(Medicamento_id);
        }
        public string InactivarMedicamento(int Medicamento_id)
        {

            using (ServicioMedicamento elMedicamento = new ServicioMedicamento())
                return elMedicamento.InactivarMedicamento(Medicamento_id);
        }
        public string ActivarMedicamento(int Medicamento_id)
        {

            using (ServicioMedicamento elMedicamento = new ServicioMedicamento())
                return elMedicamento.ActivarMedicamento(Medicamento_id);
        }

    }
}
