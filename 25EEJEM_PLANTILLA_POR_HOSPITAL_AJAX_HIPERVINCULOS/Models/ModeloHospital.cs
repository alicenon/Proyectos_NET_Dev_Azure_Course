using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _25EEJEM_PLANTILLA_POR_HOSPITAL_AJAX_HIPERVINCULOS.Models
{
    public class ModeloHospital
    {
        EntidadHospital entidad = new EntidadHospital();

        public IQueryable<HOSPITAL> GetHospitales()
        {
            var consulta = from datos in entidad.HOSPITAL
                           select datos;
            return consulta;
        }

        public IQueryable<PLANTILLA> GetPlantillaHospital(string hospitalcod)
        {
            var consulta = from datos in entidad.PLANTILLA
                           where datos.HOSPITAL_COD == hospitalcod
                           select datos;
            return consulta;
        }
    }
}