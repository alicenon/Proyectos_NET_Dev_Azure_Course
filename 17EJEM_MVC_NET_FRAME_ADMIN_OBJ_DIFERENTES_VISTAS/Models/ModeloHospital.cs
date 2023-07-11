using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17EJEM_MVC_NET_FRAME_ADMIN_OBJ_DIFERENTES_VISTAS.Models
{
    public class ModeloHospital
    {
        ContextoHospitalDataContext contexto = new ContextoHospitalDataContext();

        public List<HOSPITAL> GetHospitales()
        {
            var consulta = from datos in contexto.HOSPITAL
                           select datos;
            return consulta.ToList();
        }

        public List<PLANTILLA> GetPlantilla(int hospitalcod)
        {
            var consulta = from datos in contexto.PLANTILLA
                           where datos.HOSPITAL_COD == hospitalcod.ToString()
                           select datos;
            return consulta.ToList();

        }

        public List<DOCTOR> GetDoctores(int hospitalcod)
        {
            var consulta = from datos in contexto.DOCTOR
                           where datos.HOSPITAL_COD == hospitalcod.ToString()
                           select datos;
            return consulta.ToList();

        }
    }
}