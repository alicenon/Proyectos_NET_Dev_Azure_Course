using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _26PRACTICA_MVC_EMPLEADOS_POR_OFICIO_AJAX.Models
{
    public class ModeloHospitalEmpleados
    {
        EntidadEmpleados dbContext = new EntidadEmpleados();
        //metodo para obtener todos los empleados con linq y lambda
        public IQueryable<EMP> ObtenerTodosLosEmpleadosConLinq(string oficio)
        {
            var consulta = from datos in dbContext.EMP
                           where datos.OFICIO == oficio
                           select datos;
            return consulta;
        }

        //metodo para obtener de la tabla empleados los oficios sin repetir los campos con linq y otra con lambda
        public List<string> ObtenerOficiosSinRepetirConLinq()
        {
            List<String> oficios = new List<String>();
            var consulta = (from datos in dbContext.EMP
                            select datos.OFICIO).Distinct();
            foreach (var ofi in consulta)
            {
                oficios.Add(ofi);
            }
            return oficios;
        }
    }
}