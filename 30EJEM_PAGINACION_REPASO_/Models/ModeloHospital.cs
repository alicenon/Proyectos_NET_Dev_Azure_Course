using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _30EJEM_PAGINACION_REPASO_.Models
{
    public class ModeloHospital
    {
        EntidadHospital entidad =
           new EntidadHospital();


        public int GetNumeroEmpleadosHospital(int hospitalcod)
        {
            String hospital = hospitalcod.ToString();
            var consulta = from datos in this.entidad.EMPLEADOS_HOSPITAL
                           where datos.HOSPITAL_COD == hospital
                           select datos;
            return consulta.Count();
        }

        public List<PAGINAR_EMPLEADOS_HOSPITAL_Result>
            GetEmpleadosHospital(int posicion, int hospitalcod)
        {
            List<PAGINAR_EMPLEADOS_HOSPITAL_Result> lista =
                this.entidad.PAGINAR_EMPLEADOS_HOSPITAL(posicion, hospitalcod).ToList();
            return lista;
        }
    }
}