using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _38PRACTICA_ADMIN_OBJETOS_EN_DIFERENTES_VISTAS_SEGURIDAD.Models
{
    
    public class ModeloHospital
        
    {
        ContextoHospitalDataContext contexto = new ContextoHospitalDataContext();
        public IQueryable<HOSPITAL> GetHospitales()
        {
            
            return contexto.HOSPITAL.ToList().AsQueryable();
        }
        public IQueryable<HOSPITAL> GetHospitalesAdmin()
        {

            return contexto.HOSPITAL.ToList().AsQueryable();
        }
        public IQueryable<HOSPITAL> GetHospitalesUser()
        {

            return contexto.HOSPITAL.ToList().AsQueryable();
        }

        public List<PLANTILLA> GetPlantilla(int ID)
        {
            return contexto.PLANTILLA.Where(h => h.HOSPITAL_COD == ID.ToString()).ToList();
            //..AsQueryable()
          

        }
    }
}