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
    public class GestorVeterinario : servicio, IDisposable
    {
        public GestorVeterinario()
        {

        }
        public void Dispose()
        {

        }
        public string InsertarVeterinario(int Veterinario_cedula, string Veterinario_nombre,
                                          string Veterinario_telefono, string Veterinario_direccion, string Veterinario_estado)
        {
            Veterinario nuevoVeterinario = new Veterinario(Veterinario_cedula, Veterinario_nombre, Veterinario_telefono,
                                                            Veterinario_direccion, Veterinario_estado);
            using (ServicioVeterinario elVeterinario = new ServicioVeterinario())
                return elVeterinario.InsertarVeterinario(nuevoVeterinario);
        }
        public string ModificarVeterinario(int Veterinario_id, int Veterinario_cedula, string Veterinario_nombre,
                                  string Veterinario_telefono, string Veterinario_direccion, string Veterinario_estado)
        {
            Veterinario nuevoVeterinario = new Veterinario(Veterinario_id, Veterinario_cedula, Veterinario_nombre, Veterinario_telefono,
                                                            Veterinario_direccion, Veterinario_estado);
            using (ServicioVeterinario elVeterinario = new ServicioVeterinario())
                return elVeterinario.ModificarVeterinario(nuevoVeterinario);
        }

        public DataSet ConsultarVeterinario(int Veterinario_id)
        {
            using (ServicioVeterinario elVeterinario = new ServicioVeterinario())
            {
                return elVeterinario.ConsultarVeterinario(Veterinario_id);
            }
        }
        public DataTable ListarVeterinarios()
        {
            using (ServicioVeterinario elVeterinario = new ServicioVeterinario())
            {
                return elVeterinario.ListarVeterinarios();
            }
        }
        public string EliminarVeterinario(int Veterinario_id)
        {

            using (ServicioVeterinario elVeterinario = new ServicioVeterinario())
                return elVeterinario.EliminarVeterinario(Veterinario_id);
        }
        public string InactivarVeterinario(int Veterinario_id)
        {

            using (ServicioVeterinario elVeterinario = new ServicioVeterinario())
                return elVeterinario.InactivarVeterinario(Veterinario_id);
        }
        public string ActivarVeterinario(int Veterinario_id)
        {

            using (ServicioVeterinario elVeterinario = new ServicioVeterinario())
                return elVeterinario.ActivarVeterinario(Veterinario_id);
        }
        public DataTable ListarVeterinariosInactivos()
        {
            using (ServicioVeterinario elVeterinario = new ServicioVeterinario())
            {
                return elVeterinario.ListarVeterinariosInactivos();
            }
        }
    }


}