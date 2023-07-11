using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace _15EJEM_MVC_NF_LINQ_EMP_DTLIST_02.Models
{
    public class ModeloHospital
    {
        ContextoHospitalDataContext dbcontexto = new ContextoHospitalDataContext();

        public List<EMP> GetEmpleados()
        {
            var consulta = from datos in dbcontexto.EMP 
                           select datos;

            return consulta.ToList();


        }

        public EMP GetEmpleadoId(int idempleado)
        {
            var consulta = from datos in dbcontexto.EMP
                           where datos.EMP_NO == idempleado
                           select datos;
            return consulta.First();
        }
        //public string GetEmpleadoApellido()
        //{
        //    //EMP em = new EMP();

        //    var query =  from empleado in dbcontexto.EMP 
        //                 where empleado.APELLIDO == "SALA"
        //                 select empleado;
        //    return query.First().OFICIO;
        //}
    }

}
