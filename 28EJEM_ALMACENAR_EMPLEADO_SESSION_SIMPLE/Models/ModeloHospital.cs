using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _28EJEM_ALMACENAR_EMPLEADO_SESSION_SIMPLE.Models
{
    public class ModeloHospital
    {
        EntidadHospital entidad = new EntidadHospital();

        public IQueryable<EMP> GetEmpleados()
        {
            var consulta = from datos in this.entidad.EMP
                           select datos;
            return consulta;
        }

        public IQueryable<EMP> GetEmpleadosSession(List<int> empleados)
        {
            var consulta = from datos in this.entidad.EMP
                           where empleados.Contains(datos.EMP_NO)
                           select datos;
            return consulta;
        }
    }
}