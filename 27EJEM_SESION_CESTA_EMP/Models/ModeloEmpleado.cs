using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _27EJEM_SESION_CESTA_EMP.Models
{
    public class ModeloEmpleado
    {
        HospitalEntities entidad = new HospitalEntities();

        public IQueryable<EMP> GetEmpleados()
        {
            var consulta = from datos in entidad.EMP
                           select datos;

            return consulta;
        }
    }
}