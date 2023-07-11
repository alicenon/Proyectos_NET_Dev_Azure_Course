using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16PRACTICA_MVC_NET_FRAMEWORK_HOSPITAL_DOCTOR.Models
{
    public class ModeloHospital
    {


            DbHospitalDataContext dbcontexto = new DbHospitalDataContext();

            public List<HOSPITAL> GetEmpleados()
            {
                var consulta = from datos in dbcontexto.HOSPITAL
                               select datos;

                return consulta.ToList();


            }

        public DOCTOR GetHospId(String ID)
        {
            var consulta = from datos in dbcontexto.DOCTOR
                           where datos.HOSPITAL_COD == ID
                           select datos;
            return consulta.First();
        }

        public List<DOCTOR> GetHospitalId(String ID)
        {
            var consulta = from datos in dbcontexto.DOCTOR
                           where datos.HOSPITAL_COD == ID
                           select datos;
            return consulta.ToList();
        }

        public HOSPITAL DeleteHospitalForID(String ID)
        {
            var consulta = (from datos in dbcontexto.HOSPITAL
                           where datos.HOSPITAL_COD == ID
                            select datos).First();
            dbcontexto.HOSPITAL.DeleteOnSubmit(consulta);
            dbcontexto.SubmitChanges();
            return consulta;
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