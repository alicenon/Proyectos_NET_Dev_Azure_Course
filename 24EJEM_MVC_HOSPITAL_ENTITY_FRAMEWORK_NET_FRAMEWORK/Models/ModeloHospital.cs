using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _24EJEM_MVC_HOSPITAL_ENTITY_FRAMEWORK_NET_FRAMEWORK.Models
{
    public class ModeloHospital
    {
        HospitalEntities dbContex = new HospitalEntities();

        public IQueryable<EMP> BuscarEmpleados(String apellido)
        {
            //REALIZAMOS UNA CONSULTA PARA BUSCAR LOS EMPLEADOS
            //QUE COMIENZAN CON UNA DETERMINADA LETRA EN SU APELLIDOA
            var consulta = from datos in dbContex.EMP
                           where datos.APELLIDO.StartsWith(apellido)
                           select datos;
            return consulta;


            //dbContex.EMP.FirstOrDefault(emp=> emp.APELLIDO == apellido);
        }
    }
}