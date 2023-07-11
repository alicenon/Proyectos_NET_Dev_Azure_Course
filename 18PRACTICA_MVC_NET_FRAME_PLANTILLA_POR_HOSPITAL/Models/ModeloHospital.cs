using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _18PRACTICA_MVC_NET_FRAME_PLANTILLA_POR_HOSPITAL.Models
{
    public class ModeloHospital
    {
        DataClasses1DataContext dbContext = new DataClasses1DataContext();
        public List<PLANTILLA> GetPLANTILLA()
        {
            var consulta =from datos in dbContext.PLANTILLA
                          select datos;
            return consulta.ToList();
        }
            
        public List<HOSPITAL> GetHospitalId(String ID)
        {
            var consulta = from datos in dbContext.HOSPITAL
                           where datos.HOSPITAL_COD == ID
                           select datos;
            if (consulta.Count() > 0)
            // Si devuelve filas construimos la lista
            {
                return consulta.ToList();
            }

            return null;
        }
    }
}