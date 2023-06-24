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
    public class GestorDuenno : servicio, IDisposable
    {
        public GestorDuenno()
        {

        }
        public void Dispose()
        {

        }
        
        public string InsertarDuenno(int Duenno_cedula, string Duenno_nombre, string Duenno_apellido, 
                                    string Duenno_telefono, string Duenno_direccion, string Duenno_estado)
        {
            Duenno nuevoDuenno = new Duenno( Duenno_cedula, Duenno_nombre, Duenno_apellido,
                                           Duenno_telefono,Duenno_direccion, Duenno_estado);


            using (ServicioDuenno elDuenno = new ServicioDuenno())
            return elDuenno.InsertarDuenno(nuevoDuenno);
        }

       
        public string ModificarDuenno(int Duenno_id, int Duenno_cedula, string Duenno_nombre, string Duenno_apellido,
                            string Duenno_telefono, string Duenno_direccion, string Duenno_estado)
        {
            Duenno nuevoDuenno = new Duenno (Duenno_id,Duenno_cedula, Duenno_nombre, Duenno_apellido,
                                           Duenno_telefono, Duenno_direccion, Duenno_estado);


            using (ServicioDuenno elDuenno = new ServicioDuenno())
                return elDuenno.ModificarDuenno(nuevoDuenno);
        }

        public DataSet ConsultarDuenno(int Duenno_id)
        {
            using (ServicioDuenno elDuenno = new ServicioDuenno())
            {
                return elDuenno.ConsultarDuenno(Duenno_id);
            }
        }

        public DataTable ListarDuennos()
        {
            using (ServicioDuenno elDuenno = new ServicioDuenno())
            {
                return elDuenno.ListarDuennos();
            }

        }
        public DataTable ListarDuennosInactivos()
        {
            using (ServicioDuenno elDuenno = new ServicioDuenno())
            {
                return elDuenno.ListarDuennosInactivos();
            }

        }
        public string EliminarDuenno(int Duenno_id)
        {

            using (ServicioDuenno elDuenno = new ServicioDuenno())
                return elDuenno.EliminarDuenno(Duenno_id);
        }
        public string InactivarDuenno(int Duenno_id)
        {

            using (ServicioDuenno elDuenno = new ServicioDuenno())
                return elDuenno.InactivarDuenno(Duenno_id);
        }

        public string ActivarDuenno(int Duenno_id)
        {

            using (ServicioDuenno elDuenno = new ServicioDuenno())
                return elDuenno.ActivarDuenno(Duenno_id);
        }















    }
}
