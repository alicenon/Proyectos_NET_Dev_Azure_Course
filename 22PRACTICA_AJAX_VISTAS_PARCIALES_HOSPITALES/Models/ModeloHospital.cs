using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _22PRACTICA_AJAX_VISTAS_PARCIALES_HOSPITALES.Models
{
    public class ModeloHospital
    {
        DbHospitalesDataContext dbContext = new DbHospitalesDataContext();
        public List<HOSPITAL> GetHospitales()
        {
            var consulta = from datos in dbContext.HOSPITAL
                           select datos;
            return consulta.ToList();
        }
    }
}